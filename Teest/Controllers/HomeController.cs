using Core.Interface;
using Core.VM;
using Infrastructure.Data.DataConnection;
using Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Teest.Models;

namespace Teest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudent _IStudent;
        public HomeController( IStudent _IS)
        {
            _IStudent = _IS;
        }

        public IActionResult Index()
        {
            ViewBag.a = _IStudent.LVMS();
            return View();
        }

        public IActionResult add(VMStudent VS)
        {
            if (!ModelState.IsValid)
            {

                return RedirectToAction("error");
            }
            else
            {
                _IStudent.AddStudent(VS);
                return RedirectToAction("Index");
            }
        }
        
        public IActionResult Update(int Id)
        {
            if (true)
            {
                return View(_IStudent.UpdateStudent(Id));
            }
            else
            {
                return RedirectToAction("error");
            }
        }
       
        public IActionResult Edit(VMStudent VS)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("error");
            }
            else
            {
                _IStudent.EditStudent(VS);
                return RedirectToAction("Index");
            }
                
        }
       
        public IActionResult deletes(int id)
        {
           _IStudent.DeleteStudent(id);
           return RedirectToAction("Index");
        }
    }
}
