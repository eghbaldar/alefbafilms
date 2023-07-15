using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Constants;
using alefbafilms.domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.Persistence.Contexts
{
    public class DataBaseContext: DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options): base (options)
        {

        }
        //===================================== TABLES of Database
        public DbSet<User> Users { get; set; } // Table [Users] in Databse
        public DbSet<Role> Roles { get; set; } // Table [Roles] in Databse
        public DbSet<UserInRole> UserInRoles{ get; set; } // Table [UserInRoles] in Databse
        // End of TABELS of Database


        //===================================== Data-Seeding
        // This function will be work after [add-migration and update-database]
        // This function applies the urgent actions on the database for good!
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Describe: Whenever you want to launch the project database, the below values will be added automatically
            // Note: If you had added once the below values, you would have not been able to add those again with the same ID, so you have to change IDs.
            modelBuilder.Entity<Role>().HasData(new Role { id = 1, name = nameof(RoleConsts.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role { id = 2, name = nameof(RoleConsts.Operator) });
            modelBuilder.Entity<Role>().HasData(new Role { id = 3, name = nameof(RoleConsts.User) });
            modelBuilder.Entity<Role>().HasData(new Role { id = 4, name = nameof(RoleConsts.Guest) });

            // Make the email field unique!
            // Why? because the end-user will not be allowed to register by two the same email address
            modelBuilder.Entity<User>().HasIndex(x=> x.email).IsUnique();

            //Let show only records that their [DeleteTime] field equal with NULL, why?
            // because if this field wasn't NULL, it would mean that this record had been deleted
            modelBuilder.Entity<User>().HasQueryFilter(x => x.DeleteTime == null);
        }
        // End of Data-Seeding

    }
}
