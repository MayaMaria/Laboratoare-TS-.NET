using Grpc.Core;
using GrpcService.Data;
using GrpcService.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class PostCommentService : PostComment.PostCommentBase
    {
        private readonly ILogger<PostCommentService> _logger;
        private PostCommentContext postCommentContext;
        public PostCommentService(ILogger<PostCommentService> logger, PostCommentContext context)
        {
            _logger = logger;
            postCommentContext = context;
        }

        public override Task<PostsList> GetAllPosts(Empty empty, ServerCallContext context)
        {

            PostsList postsList = new PostsList();
            List<PostModel> postLists = new List<PostModel>();
            var result = postCommentContext.Posts.ToList<Post>();
            result.ForEach(post =>
            {
                var post_ = new PostModel();
                post_.PostId = post.PostId;
                post_.Description = post.Description;
                post_.Domain = post.Domain;
                post_.Date = post.Date;
                postLists.Add(post_);

            });

            postsList.Items.AddRange(postLists);
            return Task.FromResult(postsList);

        }

        public override Task<ResultClient> AddPost(PostModel post,ServerCallContext context)
        {
            Post post_ = new Post()
            {
                PostId = post.PostId,
                Description = post.Description,
                Domain = post.Domain,
                Date = post.Date
            };

            _logger.LogInformation("Insert post");

            try
            {
                postCommentContext.Posts.Add(post_);
                var returnVal = postCommentContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.ToString());
            }

            return Task.FromResult(new ResultClient()
            {
                Result = "Post succesfully added"
            });
        }

        public override Task<PostModel> UpdatePost(PostModel updatePost, ServerCallContext context)
        {
            var post = postCommentContext.Posts.Find(updatePost.PostId);

            if (post == null)
            {
                _logger.LogInformation("Post not found");
                return Task.FromResult(updatePost);
            }
            else
            {
                post.Description = updatePost.Description;
                post.Domain = updatePost.Domain;
                post.Date = updatePost.Date;
                _logger.LogInformation("Update post");
                postCommentContext.SaveChanges();

                var updatedPost = new PostModel()
                {
                    PostId = post.PostId,
                    Domain = post.Domain,
                    Description = post.Description,
                    Date = post.Date
                };


                return Task.FromResult(updatedPost);
            }

        }

        public override Task<PostModel> GetByIdPost(InputClient post, ServerCallContext context)
        {
            PostModel postFind = new PostModel();

            var post_ = postCommentContext.Posts.Find(post.Id);

            if(post_  != null)
            {
                postFind.PostId = post_.PostId;
                postFind.Description = post_.Description;
                postFind.Date = post_.Date;
                postFind.Domain = post_.Domain;
            }

            return Task.FromResult(postFind);
        }
        
        public override Task<ResultClient> DeletePost(InputClient post,ServerCallContext context)
        {
            var postFind = postCommentContext.Posts.Find(post.Id);

            if (postFind == null)
            {
                return Task.FromResult(new ResultClient()
                {
                    Result = " Post cannot be found"
                });
            }
          
            postCommentContext.Posts.Remove(postFind);
            postCommentContext.SaveChanges();
            return Task.FromResult(new ResultClient()
            {
                Result = $"Post with id { postFind.PostId } was deleted."
            });
            
        }

        public override Task<ResultClient> AddComment(CommentModel comment, ServerCallContext context)
        {
            Comment comment_ = new Comment()
            {
                CommentId = comment.CommentId,
                Text = comment.Text,
                PostPostId = comment.PostPostId
            };

            _logger.LogInformation("Insert post");

            try
            {
                postCommentContext.Comments.Add(comment_);
                var returnVal = postCommentContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.ToString());
            }

            return Task.FromResult(new ResultClient()
            {
                Result = "Post succesfully added"
            });
        }

        public override Task<CommentModel> UpdateComment(CommentModel updateComment, ServerCallContext context)
        {
            var comment = postCommentContext.Comments.Find(updateComment.CommentId);

            if (comment == null)
            {
                _logger.LogInformation("Comment not found");
                return Task.FromResult(updateComment);
            }
            else
            {
                comment.Text = updateComment.Text;
                comment.CommentId = updateComment.CommentId;
                comment.PostPostId = updateComment.PostPostId;
                _logger.LogInformation("Update comment");
                postCommentContext.SaveChanges();

                var updatedPost = new CommentModel()
                {
                    CommentId = comment.CommentId,
                    Text = comment.Text,
                    PostPostId = comment.PostPostId,
                  
                };


                return Task.FromResult(updatedPost);
            }

        }

        public override Task<CommentModel> GetCommentById(InputClient comment, ServerCallContext context)
        {
            CommentModel commentFind = new CommentModel();

            var comment_ = postCommentContext.Comments.Find(comment.Id);

            if (comment_ != null)
            {
                commentFind.CommentId = comment_.CommentId;
                commentFind.Text = comment_.Text;
                commentFind.PostPostId = comment_.PostPostId;
            }

            return Task.FromResult(commentFind);
        }

    }
}
