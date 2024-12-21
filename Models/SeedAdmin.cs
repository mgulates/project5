using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
    namespace project5.Models
{
    public class SeedAdmin
    {
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            DataContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<DataContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager =
                app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }

            IdentityUser? admin = await userManager.FindByNameAsync("admin");
            if (admin == null)
            {
                admin = new IdentityUser("admin")
                {
                    Email = "admin@admin.com",
                };
                await userManager.CreateAsync(admin, "admin123");  
                await userManager.AddToRoleAsync(admin, "admin");
            }

        }
    }
}
