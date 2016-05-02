using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ItransitionProject.Context
{
    class DataContext : DbContext
    {
        public DataContext() : base("ComicsDB") { }
        public DbSet<Achievment> Achievments { get; set; }
        public DbSet<Comics> Comics { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Dialog> Dialogs { get; set; }
        public DbSet<DialogTemplate> DialogTemplates { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //add relationships 
        }
    }
   
}
