﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assigment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EF_DBEntities : DbContext
    {
        public EF_DBEntities()
            : base("name=EF_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<AssignmentStatus> AssignmentStatuses { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
    }
}
