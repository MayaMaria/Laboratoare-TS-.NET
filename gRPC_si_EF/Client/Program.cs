using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            PostModel postModel = new PostModel()
            {
                Description = "Adaugare descriere",
                Domain = "testare",
                Date = "28-04-2020"
            };
            await addPost(postModel, channel);
            await getAllPosts(channel);

            await FindPostById(2, channel);
            await DeletePost(3, channel);

            postModel.PostId = 2;
            postModel.Description = "Update desriere";
            await UpdatePost(postModel, channel);
            await getAllPosts(channel);


            CommentModel commentModel = new CommentModel()
            {
                Text = "Comment text",
                PostPostId = 2
            };

            await AddComment(commentModel, channel);
            await FindCommentById(1, channel);
            commentModel.CommentId = 1;
            commentModel.Text = "Update text comment";
            await UpdateComment(commentModel, channel);


        }

        static async Task getAllPosts(GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);

            var empty = new Empty();
            var list = client.GetAllPosts(empty);

            Console.WriteLine("Show all Posts");

            foreach (var item in list.Items)
            {
                Console.WriteLine($"{item.PostId}: {item.Description} {item.Domain}");
            }
        }

        static async Task addPost(PostModel post, GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);
            var result = client.AddPost(post);
            Console.WriteLine(result.Result);

        }

        static async Task FindPostById(int id, GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);
            var result = client.GetByIdPost(new InputClient()
            {
                Id = id
            });

            Console.WriteLine($"{result.PostId} { result.Domain} {result.Description}");
        }

        static async Task DeletePost(int id, GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);
            var result = client.DeletePost(new InputClient()
            {
                Id = id
            });

            Console.WriteLine($"{result.Result}");

        }

        static async Task UpdatePost(PostModel post, GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);
            var result = client.UpdatePost(post);
            Console.WriteLine($"{result.PostId} { result.Description}");
        }



        static async Task AddComment(CommentModel comment, GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);
            var result = client.AddComment(comment);
            Console.WriteLine(result.Result);

        }

        static async Task FindCommentById(int id, GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);
            var result = client.GetCommentById(new InputClient()
            {
                Id = id
            });

            Console.WriteLine($"{result.CommentId} { result.Text}");
        }

        static async Task UpdateComment(CommentModel comment, GrpcChannel channel)
        {
            var client = new PostComment.PostCommentClient(channel);
            var result = client.UpdateComment(comment);
            Console.WriteLine($"{result.CommentId} { result.Text}");
        }

    }
}
