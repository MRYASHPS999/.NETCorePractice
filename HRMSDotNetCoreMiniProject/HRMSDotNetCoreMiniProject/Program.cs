using HRMSDotNetCoreMiniProject.Data;
using HRMSDotNetCoreMiniProject.Repository;
using HRMSDotNetCoreMiniProject.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext> 
    (
        options => options.UseSqlServer
        (
            builder.Configuration.GetConnectionString("dbconn")
        )
    );

builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddSession
(
    option =>
    {
        option.IdleTimeout = TimeSpan.FromMinutes(10);
        option.Cookie.HttpOnly = true;
        option.Cookie.IsEssential = true;
    }
);

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

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Index}/{id?}");

app.Run();
