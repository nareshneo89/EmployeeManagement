using EmployeeManagement.Models.Administration.DynamicMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.DynamicMenu.ViewModels
{
    public class MenuDetailsViewModel
    {
        public MenuItem menuItem  { get; set; }
        public string PageTitle { get; set; }
    }
}
