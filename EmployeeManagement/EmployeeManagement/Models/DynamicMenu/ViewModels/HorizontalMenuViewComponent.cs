using EmployeeManagement.Models.DynamicMenu.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.DynamicMenu.ViewModels
{
    public class HorizontalMenuViewComponent : ViewComponent
    {
        private readonly IMenuService _service;

        public HorizontalMenuViewComponent(IMenuService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var menuViewModel = new MenuViewModel
            {
                MenuItems = _service.GetMenuByUser(User)
            };

            return View(menuViewModel);
        }
    }
}
