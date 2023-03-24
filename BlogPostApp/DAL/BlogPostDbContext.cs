using System;
using BlogPostApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPostApp.DAL
{
    public class BlogPostDbContext : DbContext
    {
        public BlogPostDbContext(DbContextOptions<BlogPostDbContext> options) : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
