using EmployeeManagement.Models.Administration.DynamicMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.DynamicMenu.Repository
{
    public interface IMenuRepository
    {
        MenuItem GetMenu(int Id);
        IEnumerable<MenuItem> GetAllMenu();
        MenuItem Add(MenuItem menuItem);
        MenuItem Update(MenuItem UpdatemenuItem);
        MenuItem Delete(int id);
    }
}
