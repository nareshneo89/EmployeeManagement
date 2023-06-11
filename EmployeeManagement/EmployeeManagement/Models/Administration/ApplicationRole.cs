using EmployeeManagement.Models.Administration.DynamicMenu;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Administration
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole() { }
        public ApplicationRole(string name)
            : this()
        {
            this.Name = name;
            RoleMenus = new HashSet<ApplicationRoleMenu>();
        }

        public ICollection<ApplicationRoleMenu> RoleMenus { get; set; }
    }
}
