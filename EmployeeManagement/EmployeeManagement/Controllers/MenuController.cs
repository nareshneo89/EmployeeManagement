using EmployeeManagement.Models;
using EmployeeManagement.Models.Administration.DynamicMenu;
using EmployeeManagement.Models.DynamicMenu.Repository;
using EmployeeManagement.Models.DynamicMenu.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Authorize]
    public class MenuController : Controller
    {
        private readonly IMenuRepository menuRepository;
        private readonly AppDbContext appDbContext;

        public MenuController(IMenuRepository menuRepository, AppDbContext appDbContext)
        {
            this.menuRepository = menuRepository;
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        [AllowAnonymous]
        public ViewResult MenuList()
        {
            var model = menuRepository.GetAllMenu()
                .Select(e =>
                {
                    e.Id = e.Id;
                    return e;
                });
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AddMenu()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult AddMenu(AddMenuItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                MenuItem menuItem = new MenuItem
                {
                    Title = model.Title,
                    Description = model.Description,
                    ParentId = model.ParentId,
                    Icon = model.Icon,
                    Url = model.Url
                };
                menuRepository.Add(menuItem);
                //return RedirectToAction("Details", new { id = menuItem.Id });
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ViewResult EditMenu(int id)
        {
            MenuItem menuItem = menuRepository.GetMenu(id);
            UpdateMenuItemViewModel updateMenuItemViewModel = new UpdateMenuItemViewModel()
            {
                Id = menuItem.Id,
                Title = menuItem.Title,
                Description = menuItem.Description,
                ParentId = menuItem.ParentId,
                Icon = menuItem.Icon,
                Url = menuItem.Url
            };
            return View(updateMenuItemViewModel);
            
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult EditMenu(UpdateMenuItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                MenuItem menuItem = menuRepository.GetMenu(model.Id);
                menuItem.Title = model.Title;
                menuItem.Description = model.Description;
                menuItem.ParentId = model.ParentId;
                menuItem.Icon = model.Icon;
                menuItem.Url = model.Url;

                //menuRepository.Update(menuItem);

                appDbContext.Entry(menuItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                appDbContext.SaveChanges();
                return RedirectToAction("MenuList");
            }
            return View();
        }

    }
}
