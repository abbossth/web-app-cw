using BlogPostApp.Models;
using System.Collections.Generic;

namespace BlogPostApp.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetCommentsByPostId(int postId);
        Comment GetCommentById(int id);
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(int id);
        object GetCommentsByPostId(int? id);
    }
}
