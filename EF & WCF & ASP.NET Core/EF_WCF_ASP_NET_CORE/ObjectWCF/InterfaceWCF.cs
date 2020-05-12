using System;
using System.Collections.Generic;
using System.ServiceModel;
using PostComment;
namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePost
    {
        [OperationContract]
        bool AddPost(Post post);
        [OperationContract]
        Post UpdatePost(Post post);
        [OperationContract]
        int DeletePost(Guid id);
        [OperationContract]
        Post GetPostById(Guid id);
        [OperationContract]
        List<Post> GetPosts();
    }

    [ServiceContract]
    interface InterfaceComment
    {
        [OperationContract]
        bool AddComment(Comment comment);
        [OperationContract]
        Comment UpdateComment(Comment newComment);
        [OperationContract]
        Comment GetCommentById(Guid id);
    }

    [ServiceContract]
    interface IPostComment : InterfacePost, InterfaceComment
    {
    }
}