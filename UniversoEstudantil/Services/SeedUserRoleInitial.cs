using Microsoft.AspNetCore.Identity;
using UniversoEstudantil.Areas.Identity.Data;

namespace UniversoEstudantil.Services
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedRolesAsync()
        {
            if (! await _roleManager.RoleExistsAsync("User"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Gerente"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Gerente";
                role.NormalizedName = "GERENTE";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }
        }

        public async Task SeedUsersAsync()
        {
            if (await _userManager.FindByEmailAsync("usuario@user.com") == null)
            {
                //create a new accounnt if there is not any already in the environment
                ApplicationUser user = new ApplicationUser();
                user.Email = "usuario@user.com";
                user.UserName = "usuario@user.com";
                user.Nome = "usuario";
                user.Sobrenome = "user";

                IdentityResult result = await _userManager.CreateAsync(user, "Uusario#2023");

                if (result.Succeeded)
                {
                    //add a user to a specific role
                    await _userManager.AddToRoleAsync(user, "User");
                }
            }

            if (await _userManager.FindByEmailAsync("admin@admin.com") == null)
            {
                //create a new accounnt if there is not any already in the environment
                ApplicationUser user = new ApplicationUser();
                user.Email = "admin@admin.com";
                user.UserName = "admin@admin.com";
                user.Nome = "admin";
                user.Sobrenome = "user";

                IdentityResult result = await _userManager.CreateAsync(user, "Admin#2023");

                if (result.Succeeded)
                {
                    //add a user to a specific role
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }



            if (await _userManager.FindByEmailAsync("gerente@user.com") == null)
            {
                //create a new accounnt if there is not any already in the environment
                ApplicationUser user = new ApplicationUser();
                user.Email = "gerente@user.com";
                user.UserName = "gerente@user.com";
                user.Nome = "gerente";
                user.Sobrenome = "user";

                IdentityResult result = await _userManager.CreateAsync(user, "Gerente#2023");

                if (result.Succeeded)
                {
                    //add a user to a specific role
                    await _userManager.AddToRoleAsync(user, "Gerente");
                }
            }

        }
    }
}
