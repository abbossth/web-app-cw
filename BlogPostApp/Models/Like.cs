using Microsoft.Extensions.Hosting;

namespace BlogPostApp.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
