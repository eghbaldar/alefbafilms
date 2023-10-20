using alefbafilm6.Domain.Entities.Contact;
using alefbafilm6.Domain.Entities.Gallery;
using alefbafilm6.Domain.Entities.Newsletter;
using alefbafilm6.Domain.Entities.Pages;
using alefbafilm6.Domain.Entities.Productions;
using alefbafilm6.Domain.Entities.Staffs;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Constants;
using alefbafilms.domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.Persistence.Contexts
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }
        //===================================== TABLES of Database
        // USER
        public DbSet<User> Users { get; set; } // Table [Users] in Databse
        public DbSet<Role> Roles { get; set; } // Table [Roles] in Databse
        public DbSet<UserInRole> UserInRoles { get; set; } // Table [UserInRoles] in Databse

        // GALLERY
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<GalleryCategory> GalleryCategory { get; set; }
        public DbSet<GalleryInCategory> GalleryInCategory { get; set; }


        // Pages
        public DbSet<Page> Pages { get; set; }

        //Staff
        public DbSet<Staff> Staff { get; set; }

        // Contact
        public DbSet<Contact> Contacts { get; set; }

        // Newsletter
        public DbSet<Newsletter> Newsletters { get; set; }

        // Productions
        public DbSet<Products> Products { get; set; }
        //===================================== End of TABELS of Database



        // This function will be work after [add-migration and update-database]
        // This function applies the urgent actions on the database for good!
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //===================================== Data-Seeding
            // Describe: Whenever you want to launch the project database, the below values will be added automatically
            // Note: If you had added once the below values, you would have not been able to add those again with the same ID, so you have to change IDs.
            modelBuilder.Entity<Role>().HasData(new Role { id = 1, name = nameof(RoleConsts.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role { id = 2, name = nameof(RoleConsts.Operator) });
            modelBuilder.Entity<Role>().HasData(new Role { id = 3, name = nameof(RoleConsts.User) });
            modelBuilder.Entity<Role>().HasData(new Role { id = 4, name = nameof(RoleConsts.Guest) });
            //===================================== End of Data-Seeding

            // Make the email field unique!
            // Why? because the end-user will not be allowed to register by two the same email address
            modelBuilder.Entity<User>().HasIndex(x => x.email).IsUnique();
            //END

            //Let show only records that their [DeleteTime] field equal with NULL, why?
            // because if this field wasn't NULL, it would mean that this record had been deleted
            modelBuilder.Entity<User>().HasQueryFilter(x => x.DeleteTime == null);
            modelBuilder.Entity<Staff>().HasQueryFilter(x => x.DeleteTime == null);
            modelBuilder.Entity<Gallery>().HasQueryFilter(x=> x.DeleteTime == null);
            modelBuilder.Entity<Newsletter>().HasQueryFilter(x => x.DeleteTime== null);
            modelBuilder.Entity<Products>().HasQueryFilter(x=>x.DeleteTime== null);
            //END

            // set default value for "IsCheck" property of "Contacts" entity with every insert into the databse
            modelBuilder.Entity<Contact>().Property(x => x.IsCheck).HasDefaultValue(false);
            //END

            //Change "Scheme" of table to "optional value"
            // if you did not change it, you would have the default scheme, such us: "alefbaUserEghbaldar.Contact,..."
            // why? because during creating table, EF is going to use "username" of the database the scheme.
            modelBuilder.Entity<User>().ToTable("Users", "dbo");
            modelBuilder.Entity<Role>().ToTable("Roles", "dbo");
            modelBuilder.Entity<UserInRole>().ToTable("UserInRoles", "dbo");
            modelBuilder.Entity<Gallery>().ToTable("Gallery", "dbo");
            modelBuilder.Entity<GalleryCategory>().ToTable("GalleryCategory", "dbo");
            modelBuilder.Entity<GalleryInCategory>().ToTable("GalleryInCategory", "dbo");
            modelBuilder.Entity<Page>().ToTable("Pages", "dbo");
            modelBuilder.Entity<Staff>().ToTable("Staff", "dbo");
            modelBuilder.Entity<Contact>().ToTable("Contacts", "dbo");
            modelBuilder.Entity<Newsletter>().ToTable("Newsletters", "dbo");
            modelBuilder.Entity<Products>().ToTable("Products", "dbo");
            //END
        }
        

    }
}
