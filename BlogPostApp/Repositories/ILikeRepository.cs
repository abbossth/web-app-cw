using BlogPostApp.Models;
using System.Collections.Generic;

namespace BlogPostApp.Repositories
{
    public interface ILikeRepository
    {
        IEnumerable<Like> GetLikesByPostId(int postId);
        void AddLike(Like like);
        void DeleteLike(int id);
        object GetLikesByPostId(int? id);
    }
}
