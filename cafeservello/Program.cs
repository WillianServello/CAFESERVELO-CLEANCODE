using Microsoft.EntityFrameworkCore;

namespace cafeservello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                 .AddControllersWithViews()
                 .AddRazorOptions(options =>
                 {
                     options.ViewLocationFormats.Add("/Views/Pages/{1}/{0}.cshtml");
                 });

            builder.Services.AddDbContext<BancoContext>(options =>
                options.UseMySQL(builder.Configuration.GetConnectionString("Database")!));

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }
            

            app.UseHttpsRedirection();

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
