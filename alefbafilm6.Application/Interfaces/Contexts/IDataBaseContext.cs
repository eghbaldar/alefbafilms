using alefbafilm6.Domain.Entities.Gallery;
using alefbafilm6.Domain.Entities.Pages;
using alefbafilm6.Domain.Entities.Staffs;
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
        ///////////////////////////////////////////////////////////////////////////////////////// Entities
        // USER
        DbSet<User> Users { get; set; } // Table [Users] in Databse
        DbSet<Role> Roles { get; set; } // Table [Roles] in Databse
        DbSet<UserInRole> UserInRoles { get; set; } // Table [UserInRoles] in Databse

        // GALLERY
        DbSet<Gallery> Gallery { get; set; }
        DbSet<GalleryCategory> GalleryCategory { get; set; }
        DbSet<GalleryInCategory> GalleryInCategory { get; set; }

        // Pages
        DbSet<Page> Pages { get; set; }

        // Staff
        DbSet<Staff> Staff { get; set; }

        ///////////////////////////////////////////////////////////////////////////////////////// Methods
        //SaveChanges
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

    }
}
