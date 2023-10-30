using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UniversoEstudantil.Areas.Identity.Data;
using UniversoEstudantil.Models.ViewsModel;

namespace UniversoEstudantil.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AdminController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Users()
        {
            var model = new UserListViewModel
            {
                UserManager = _userManager // Pass the UserManager to the model
            };

            return View(model);
        }
    }
}
