using Eduhome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {
        }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Categories> Course_Categories { get; set; }
        public DbSet<Course_Comment> Course_Comments { get; set; }
        public DbSet<Course_Tag> Course_Tags { get; set; }
        public DbSet<Course_About> Course_Abouts { get; set; }
        public DbSet<CourseToCategory> CourseToCategories { get; set; }
        public DbSet<CourseToTag> CourseToTags { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Teacher_Hobbie> Teacher_Hobbies { get; set; }
        public DbSet<Teacher_Skill> Teacher_Skills { get; set; }
        public DbSet<Teacher_Social> Teacher_Socials { get; set; }
        public DbSet<TeacherToSocial> TeacherToSocials { get; set; }

    }
}
