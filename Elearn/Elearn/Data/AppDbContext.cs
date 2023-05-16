using Elearn.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Elearn.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<FeaturedCourseAuthor> FeaturedCoursesAuthor { get; set; }
        public DbSet<FeaturedCourse> FeaturedCourses { get; set; }
        public DbSet<FeaturedCourseImage> FeaturedCoursesImage { get;set; }
        public DbSet<CourseAuthor> CourseAuthors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<CourseAuthorImage> CourseAuthorImages { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<NewsAuthor> NewsAuthors { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }
    }
}
