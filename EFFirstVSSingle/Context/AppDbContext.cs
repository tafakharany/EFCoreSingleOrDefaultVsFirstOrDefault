using EFFirstVSSingle.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFirstVSSingle.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Name = "Taha"}, 
                new Student() { StudentId = 2, Name = "Salah"}, 
                new Student() { StudentId = 3, Name = "Osama"}, 
                new Student() { StudentId = 4, Name = "Omar"}, 
                new Student() { StudentId = 5, Name = "Selema"}, 
                new Student() { StudentId = 6, Name = "Omar"}               
                );
            modelBuilder.Entity<Course>().HasData(
                new Course() { CourseId = 1, CourseName = "DS"}, 
                new Course() { CourseId = 2, CourseName = "Algorithms"}, 
                new Course() { CourseId = 3, CourseName = "Design Patterns"}, 
                new Course() { CourseId = 4, CourseName = "OOP"}
                           
                );
            base.OnModelCreating(modelBuilder);
        }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(@"Server=.;Database=StudentCoursesDB;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
