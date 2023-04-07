using BlogPostApp.DAL;
using BlogPostApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlogPostApp.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogPostDbContext _context;

        public CommentRepository(BlogPostDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetCommentsByPostId(int postId)
        {
            return _context.Comments.Where(c => c.PostId == postId).ToList();
        }

        public Comment GetCommentById(int id)
        {
            return _context.Comments.FirstOrDefault(c => c.Id == id);
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            var comment = GetCommentById(id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }

        public object GetCommentsByPostId(int? id)
        {
            throw new System.NotImplementedException();
        }
    }

}
