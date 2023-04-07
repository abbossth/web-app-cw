using BlogPostApp.DAL;
using BlogPostApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlogPostApp.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogPostDbContext _context;

        public PostRepository(BlogPostDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public Post GetPostById(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            var post = GetPostById(id);
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }
    }
}
