using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class CmsContext: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicTrainer> TopicTrainers { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<TraineevCourse> TraineevCourses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Trainingstaff> Trainningstaffs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-5U0N3RI3;Initial Catalog=CMSWebApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TopicTrainer>().HasKey(tt => new { tt.TrainerID, tt.TopicID });

            modelBuilder.Entity<TopicTrainer>()
                .HasOne<Trainer>(tt => tt.Trainer)
                .WithMany(s => s.TopicTrainers)
                .HasForeignKey(tt => tt.TrainerID);

            modelBuilder.Entity<TopicTrainer>()
                .HasOne<Topic>(tt => tt.Topic)
                .WithMany(s => s.TopicTrainers)
                .HasForeignKey(tt => tt.TopicID);

            modelBuilder.Entity<TraineevCourse>().HasKey(tc => new { tc.TraineeID, tc.CourseID });

            modelBuilder.Entity<TraineevCourse>()
                .HasOne<Trainee>(tc => tc.Trainee)
                .WithMany(s => s.TraineevCourses)
                .HasForeignKey(tc => tc.TraineeID);

            modelBuilder.Entity<TraineevCourse>()
                .HasOne<Course>(tc => tc.Course)
                .WithMany(s => s.TraineevCourses)
                .HasForeignKey(tc => tc.CourseID);
        }
    }
}
