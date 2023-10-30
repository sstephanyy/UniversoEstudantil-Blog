using Microsoft.AspNetCore.Identity;
using UniversoEstudantil.Areas.Identity.Data;

namespace UniversoEstudantil.Models.ViewsModel
{
    public class UserListViewModel
    {
        public UserManager<ApplicationUser> UserManager { get; set; }
    }
}
