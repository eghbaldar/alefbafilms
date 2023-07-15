using alefbafilms.domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.application.Interfaces.Contexts
{
   public interface IDataBaseContext
    {
         DbSet<User> Users { get; set; } // Table [Users] in Databse
         DbSet<Role> Roles { get; set; } // Table [Roles] in Databse
         DbSet<UserInRole> UserInRoles { get; set; } // Table [UserInRoles] in Databse

        //SaveChanges
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

    }
}
