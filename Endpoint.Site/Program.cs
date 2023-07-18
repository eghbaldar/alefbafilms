using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Gallery.FacadePattern;
using alefbafilm6.Application.Services.Users.FacadePattern;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.application.Services.Users.Commands.ActiveUsers;
using alefbafilms.application.Services.Users.Commands.DeleteUsers;
using alefbafilms.application.Services.Users.Commands.PostUsers;
using alefbafilms.application.Services.Users.Commands.UpdateUsers;
using alefbafilms.application.Services.Users.Queries.AuthUsers.SignIn;
using alefbafilms.application.Services.Users.Queries.GetRoles;
using alefbafilms.application.Services.Users.Queries.GetUsers;
using alefbafilms.Common.Constants;
using alefbafilms.Persistence.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ASN // Add DataContext Dependencies & Other Dependecies such as "Users Services"
builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();

// Facade of User
builder.Services.AddScoped<IUserFacade, UserFacade>();
// Facade of Gallery
builder.Services.AddScoped<IGalleryFacade,GalleryFacade>();

// ASN // Add SQL SERVICE Provider services
var connStr = builder.Configuration.GetConnectionString("LocalServer"); // Get connectionstring value directly from "appsetting.json" file
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(connStr));

// ASN // Add Authentication & Auhortization

builder.Services.AddAuthentication(option =>
{
    option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(option =>
{
    option.LoginPath = new PathString("/admin/users/auth/signin");
    option.ExpireTimeSpan = TimeSpan.FromMinutes(1);
    option.AccessDeniedPath = new PathString("/admin/users/auth/signin");
});

builder.Services.AddAuthorization(option =>
{
    option.AddPolicy(RoleConsts.Admin, policy => policy.RequireRole(RoleConsts.Admin));
    option.AddPolicy(RoleConsts.Operator, policy => policy.RequireRole(RoleConsts.Operator));
    option.AddPolicy(RoleConsts.User, policy => policy.RequireRole(RoleConsts.User));
    option.AddPolicy(RoleConsts.Guest, policy => policy.RequireRole(RoleConsts.Guest));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//ASN// Introduce "area:Admin" to routing system!

//Static Route
app.MapControllerRoute(
        name: "admin_authentication",
        pattern: "{area:exists}/users/auth/{type}",
        defaults: new { controller = "Auth", action = "Index", type = "signin" }
);

//Access to area sections
app.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.Run();
