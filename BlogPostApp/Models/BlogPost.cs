using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BlogPostApp.Models
{
    public class BlogPost
    {
        // ID
        [Range(0, int.MaxValue)]
        public int Id { get; set; }

        // TITLE
        [Required, MinLength(2)]
        public string Title { get; set; }

        // CONTENT
        [Required, MinLength(50)]
        public string Content { get; set; }

        // PUBLISHED DATETIME
        public DateTime DatePublished { get; set; } = DateTime.Now;

        // CATEGORIES
        [Required]
        public Categories Categories { get; set; }

        // COMMENTS
        public virtual ICollection<Comment> Comments { get; set; }
    }

    // CATEGORIES THAT WILL BE REPRESENTED AS LIST IN SELECT AND OPTION TAG IN VIEW
    public enum Categories
    {
        Food,
        Travel,
        Health,
        Lifestyle,
        Fashion,
        Photography,
        Personal,
        DIY,
        Other
    }
}
