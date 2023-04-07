using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPostApp.Models
{
    public class Comment
    {
        // ID
        [Range(0, int.MaxValue)]
        public int Id { get; set; }

        // NAME
        [Required, MinLength(2)]
        public string Name { get; set; }

        // CONTENT
        [Required, MinLength(2)]
        public string Content { get; set; }

        // DATE POSTED
        [Required]
        public DateTime DatePosted { get; set; }
        
        // BLOG POST FK
        public int PostId { get; set; }
        
        // BLOG POST
        public virtual Post Post { get; set; }
    }
}
