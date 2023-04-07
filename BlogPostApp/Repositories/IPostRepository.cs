using BlogPostApp.Models;
using System.Collections.Generic;

namespace BlogPostApp.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
    }
}
