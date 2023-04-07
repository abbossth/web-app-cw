using BlogPostApp.DAL;
using BlogPostApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlogPostApp.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly BlogPostDbContext _context;

        public LikeRepository(BlogPostDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Like> GetLikesByPostId(int postId)
        {
            return _context.Likes.Where(l => l.PostId == postId).ToList();
        }

        public void AddLike(Like like)
        {
            _context.Likes.Add(like);
            _context.SaveChanges();
        }

        public void DeleteLike(int id)
        {
            var like = _context.Likes.FirstOrDefault(l => l.Id == id);
            _context.Likes.Remove(like);
            _context.SaveChanges();
        }

        public object GetLikesByPostId(int? id)
        {
            throw new System.NotImplementedException();
        }
    }

}
