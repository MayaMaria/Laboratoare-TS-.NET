using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PostComment
{
    class APIs
    {
    }
    public partial class Post
    {
        public bool AddPost()
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                bool bResult = false; if (this.PostId == 0)
                { var it = ctx.Entry<Post>(this).State = EntityState.Added; ctx.SaveChanges(); bResult = true; }
                return bResult;
            }
        }
        public Post UpdatePost(Post newPost)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                Post oldPost = ctx.Posts.Find(newPost.PostId); if (oldPost == null)
                // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description; oldPost.Domain = newPost.Domain; oldPost.Date = newPost.Date; ctx.SaveChanges(); return oldPost;
            }
        }
        public int DeletePost(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid =@p0", id);
            }
        }
        public Post GetPostById(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p; if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null; // trebuie verificat in apelant
            }
        }
        public List<Post> GetAllPosts()
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();// Obligatoriu de verificat in apelant rezultatul primit.
            }
        }
    }

    public partial class Comment
    {
        public bool AddComment()
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                bool bResult = false;
                if (this == null || this.CommentId == 0)
                    return bResult;
                if (this.CommentId == 0)
                {
                    ctx.Entry<Comment>(this).State = EntityState.Added;
                    Post p = ctx.Posts.Find(this.PostPostId);
                    ctx.Entry<Post>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Comment UpdateComment(Comment newComment)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                Comment oldComment = ctx.Comments.Find(newComment.CommentId);
                //Deoarece parametrul este un Comment ar trebui verificata fiecare 
                // proprietate din newComment daca are valoare atribuita si 
                // daca valoarea este diferita de cea din bd.
                // Acest lucru il fac numai la modificarea asocierii.
                if (newComment.Text != null)
                    oldComment.Text = newComment.Text;
                if ((oldComment.PostPostId != newComment.PostPostId) && (newComment.PostPostId != 0))
                {
                    oldComment.PostPostId = newComment.PostPostId;
                }
                ctx.SaveChanges();
                return oldComment;
            }
        }
        public Comment GetCommentById(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                var items = from c in ctx.Comments where (c.CommentId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }

    public static class API
    {
        public static bool AddPost(Post post)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                bool bResult = false;
                if (post.PostId == 0)
                {
                    var it = ctx.Entry<Post>(post).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public static Post UpdatePost(Post newPost)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {// Ce e in bd. PK nu poate fi modificata
                Post oldPost = ctx.Posts.Find(newPost.PostId);
                if (oldPost == null)
                // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public static int DeletePost(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid =@p0", id);
            }
        }///<summary>///Returnez un Post si toate Comment-urile asociate lui///</summary>///<param name="id"></param>///<returns></returns>
        public static Post GetPostById(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null;
            }
        }
        ///<summary>///Returnez toate Post-urile si Comment-urile corespunzatoare///</summary>///<returns></returns>
        public static List<Post> GetAllPosts()
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
            }
        }// Comment table
        public static bool AddComment(Comment comment)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                bool bResult = false;
                if (comment == null || comment.PostPostId == 0)
                    return bResult;
                if (comment.CommentId == 0)
                {
                    ctx.Entry<Comment>(comment).State = EntityState.Added;
                    Post p = ctx.Posts.Find(comment.PostPostId);
                    ctx.Entry<Post>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges(); bResult = true;
                }
                return bResult;
            }
        }
        public static Comment UpdateComment(Comment newComment)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                Comment oldComment = ctx.Comments.Find(newComment.CommentId);
                if (newComment.Text != null)
                    oldComment.Text = newComment.Text;
                if ((oldComment.PostPostId != newComment.PostPostId) && (newComment.PostPostId != 0))
                {
                    oldComment.PostPostId = newComment.PostPostId;
                }
                ctx.SaveChanges();
                return oldComment;
            }
        }
        public static Comment GetCommentById(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                var items = from c in ctx.Comments where (c.CommentId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }
}

