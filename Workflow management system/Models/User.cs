using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Workflow_management_system.Models
{
     [Table("users")]
     public class User
     {
          [Key]
          [Required]
          public string ID { get; set; }
          [Required]
          [Display(Name = "Email")]
          [EmailAddress]
          public string email { get; set; }
          [Required]
          [DataType(DataType.Password)]
          [MinLength(6)]
          [Display(Name = "Password")]
          public string password { get; set; }
          [Display(Name = "First Name")]
          public string firstname { get; set; }
          [Display(Name = "Last Name")]
          public string lastname { get; set; }
          [Required]
          [Display(Name = "Role")]
          public string role { get; set; }
          [Display(Name = "Level")]
          public string level { get; set; }

     }
     [Table("courseassignment")]
     public class CourseAssignViewModel
     {
          [Key]
          [Column("Lecturer",Order =0)]
          public string Lecturer { get; set; }
          [Key]
          [Column("Coursecode",Order =1)]
          public string Coursecode { get; set; }
     }
     [Table("csc502.courseassignment_view")]
     public class CourseAssignment
     {
          public string ID { get; set; }
          public string Email { get; set; }
          public string Firstname { get; set; }
          public string Lastname { get; set; }
          public string CourseAssigned { get; set; }
     }
     [Table("course")]
     public class Course{
          [Key]
          public string Code { get; set; }
          public string Title { get; set; }
     }
     public class Csc502DBContext : DbContext
     {
          public Csc502DBContext() : base(nameOrConnectionString: "DefaultConnection") { }
          protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {
               base.OnModelCreating(modelBuilder);
               //modelBuilder.Entity<User>().HasKey(l => l.id);
          }
          public virtual DbSet<User> Users { get; set; }
          public virtual DbSet<CourseAssignment> CourseAssignmentsView { get; set; }
          public virtual DbSet<CourseAssignViewModel> LecturerAssignments { get; set; }
          public virtual DbSet<Course> Courses { get; set; }
     }
     
}