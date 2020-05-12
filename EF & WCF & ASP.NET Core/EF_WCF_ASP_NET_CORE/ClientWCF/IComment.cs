//using System.ServiceModel;

//namespace ClientWCF
//{
//    [ServiceContract]
//    public interface IComment
//    {
//        // Insert, Update, Delete Comment
//        [OperationContract]
//        CommentDTO GetCommentById(int id);
//        [OperationContract]
//        CommentDTO SubmitComment(CommentDTO comment);
//        [OperationContract(Name = "AddCommment")]
//        CommentDTO SubmitComment(int postId, CommentDTO comment);
//        [OperationContract]
//        CommentDTO UpdateComment(CommentDTO oldComment, CommentDTO newComment);
//        [OperationContract]
//        bool DeleteComment(int commentId);
//    }
//}
