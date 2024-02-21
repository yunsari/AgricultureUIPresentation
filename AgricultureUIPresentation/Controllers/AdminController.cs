﻿using AgricultureUIPresentation.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUIPresentation.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Index()
        {
            var values = _adminService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.Insert(admin);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAdmin(int id)
        {
            var values = _adminService.GetById(id);
            _adminService.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
