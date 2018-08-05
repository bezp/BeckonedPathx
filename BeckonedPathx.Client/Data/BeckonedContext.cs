using BeckonedPathx.Client.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BeckonedPathx.Client.Data
{
    public class BeckonedContext : DbContext
    {
        public BeckonedContext() : base("BeckonedContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Introducing FOREIGN KEY constraint 'FK_dbo.Post_dbo.User_UserId' on table 'Post' 
            //may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON 
            //UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
            //Could not create constraint or index.

            //modelBuilder.Entity<Post>()
            //    .HasRequired(p => p.User)
            //    .WithMany(u => u.Posts)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithRequired(p => p.User)
                .WillCascadeOnDelete(false);
        }


    }
}