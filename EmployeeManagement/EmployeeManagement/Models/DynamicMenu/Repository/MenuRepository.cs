using EmployeeManagement.Models.Administration.DynamicMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.DynamicMenu.Repository
{
    public class MenuRepository //: IMenuRepository
    {
        private readonly AppDbContext context;

        public MenuRepository(AppDbContext context)
        {
            this.context = context;
        }

        //public MenuItem Add(MenuItem menuItem)
        //{
        //    context.MenuItems.Add(menuItem);
        //    context.SaveChanges();
        //    return menuItem;
        //}

        //public MenuItem Delete(int id)
        //{
        //    MenuItem menuItem = context.MenuItems.Find(id);
        //    if (menuItem != null)
        //    {
        //        context.MenuItems.Remove(menuItem);
        //        context.SaveChanges();
        //    }
        //    return menuItem;
        //}

        //public IEnumerable<MenuItem> GetAllMenu()
        //{
        //    return context.MenuItems;
        //}

        //public MenuItem GetMenu(int Id)
        //{
        //    return context.MenuItems.Find(Id);
        //}

        //public MenuItem Update(MenuItem UpdatemenuItem)
        //{
        //    context.Entry(UpdatemenuItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            
            
        //    //var menu = context.Employees.Attach(UpdatemenuItem);
        //    //var menu = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    context.SaveChanges();
        //    return UpdatemenuItem;
        //}
    }
}
