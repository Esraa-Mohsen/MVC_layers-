using Layers_DI.Models;
using Layers_DI.Reposiotries;
using Layers_DI.Services;
using Microsoft.EntityFrameworkCore;

namespace Layers_DI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<CompanyDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("myCS"));
            });
            builder.Services.AddScoped<IEmployeeRepo,EmployeeRepo>();
            builder.Services.AddScoped<IEmployeeServics, EmployeeServics>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}