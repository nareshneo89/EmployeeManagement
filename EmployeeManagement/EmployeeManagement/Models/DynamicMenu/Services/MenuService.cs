using EmployeeManagement.Models.Administration.DynamicMenu;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.DynamicMenu.Services
{
    public class MenuService //: IMenuService
    {
        private readonly AppDbContext appDbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public MenuService(AppDbContext appDbContext, UserManager<ApplicationUser> userManager)
        {
            this.appDbContext = appDbContext;
            this.userManager = userManager;
        }

        //public List<MenuItem> GetMenuByUser(IPrincipal user)
        //{
        //    if (user == null)
        //    {
        //        return new List<MenuItem>();
        //    }

        //    var principal = user as ClaimsPrincipal;

        //    var id = userManager.GetUserId(principal);

        //    var viewableItems = principal.Claims
        //        .Where(e => e.Value == "View")
        //        .Select(item => item.Type)
        //        .ToList();

        //    var result = appDbContext.MenuItems
        //        .Where(item => viewableItems.Any(u => item.Id.ToString() == u))
        //        .ToList();

        //    return result;
        //}
    }
}
