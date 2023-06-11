using EmployeeManagement.Models.Administration.DynamicMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.DynamicMenu.Services
{
    public interface IMenuService
    {
        public List<MenuItem> GetMenuByUser(IPrincipal user);
    }
}
