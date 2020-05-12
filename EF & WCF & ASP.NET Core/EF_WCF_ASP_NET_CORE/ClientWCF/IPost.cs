//using System.Collections.Generic;
//using System.ServiceModel;

//namespace ClientWCF
//{
//    [ServiceContract]
//    public interface IPost
//    {
//        [OperationContract]
//        void Cleanup();
//        [OperationContract]
//        PostDTO GetPostById(int id);
//        [OperationContract]
//        PostDTO GetPostByTitle(string title);
//        // Insert, Update, Delete Post
//        [OperationContract]
//        PostDTO SubmitPost(PostDTO post);
//        [OperationContract]
//        PostDTO UpdatePost(PostDTO newPost);
//        [OperationContract]
//        bool DeletePost(int postId);
//        [OperationContract]
//        List<PostDTO> GetAllPosts();
//    }
//}
