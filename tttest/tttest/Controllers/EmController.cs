using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tttest.Models;
using tttest.service;

namespace tttest.Controllers
{
    public class EmController : Controller
    {
        private readonly IEmployee employees;
     
        public EmController(IEmployee s)
        {
            employees = s;
        }
        public IActionResult Index()
        {
            ViewBag.e = employees.Getall();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empolyee empolyee)
        {
            employees.Save(empolyee);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var cs =  employees.Getid(id);
            return View(cs);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Empolyee empolyee)
        {
            employees.Update(empolyee);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            
            employees.Delete(id);
            return RedirectToAction("Index");

        }

    }
}
