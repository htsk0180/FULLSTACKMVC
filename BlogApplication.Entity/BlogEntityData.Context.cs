﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogApplication.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BlogEntities : DbContext
    {
        public BlogEntities()
            : base("name=BlogEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoryList> CategoryList { get; set; }
        public virtual DbSet<HeaderZone> HeaderZone { get; set; }
        public virtual DbSet<MenuZone> MenuZone { get; set; }
        public virtual DbSet<PostCommentList> PostCommentList { get; set; }
        public virtual DbSet<PostList> PostList { get; set; }
        public virtual DbSet<PostTagList> PostTagList { get; set; }
        public virtual DbSet<TagList> TagList { get; set; }
        public virtual DbSet<UserList> UserList { get; set; }
    }
}
