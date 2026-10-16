using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace FinNexus.Infrastructure.Identity
{
    public static class IdentitySeeder
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole<Guid>> roleManager)
        {
            var role = await roleManager.FindByNameAsync(Roles.Admin);

            if (role is null)
            {
                var result = await roleManager.CreateAsync(
                    new IdentityRole<Guid>(Roles.Admin));

                if (!result.Succeeded)
                {
                    throw new InvalidOperationException(
                        $"Failed to create role '{Roles.Admin}'. " +
                        string.Join("; ", result.Errors.Select(e => e.Description)));
                }
            }
        }

        public static async Task SeedAdminUserAsync(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            var identitySection = configuration.GetRequiredSection("Identity");
            var email = identitySection["AdminEmail"];
            var password = identitySection["AdminPassword"];

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                throw new InvalidOperationException("Admin identity configuration is missing.");
            }

            var adminUser = await userManager.FindByEmailAsync(email);

            if (adminUser is null)
            {
                var newAdminUser = new ApplicationUser
                {
                    UserName = "Admin",
                    Email = email,
                    EmailConfirmed = true,
                };

                var createdAdmin = await userManager.CreateAsync(
                    newAdminUser,
                    password
                );

                if (!createdAdmin.Succeeded)
                {
                    throw new InvalidOperationException(
                        $"Failed to create admin user. " +
                        string.Join("; ", createdAdmin.Errors.Select(e => e.Description)));
                }

                await AssignUserRole(userManager, newAdminUser, Roles.Admin);
            }
            else
            {
                await AssignUserRole(userManager, adminUser, Roles.Admin);
            }
        }

        private static async Task AssignUserRole(UserManager<ApplicationUser> userManager, ApplicationUser user, string role)
        {
            var userInRole = await userManager.IsInRoleAsync(user, role);

            if (!userInRole)
            {
                var addToRoleResult = await userManager.AddToRoleAsync(user, role);

                if (!addToRoleResult.Succeeded)
                {
                    throw new InvalidOperationException(
                        $"Failed to add user '{user.UserName}' to role '{role}'. " +
                        string.Join("; ", addToRoleResult.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}