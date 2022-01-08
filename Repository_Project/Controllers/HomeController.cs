using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository_Project.Models;
using SCA.BLR.Interfaces;
using SCA.BLR.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentBLR _studentBLR;
        public HomeController(IStudentBLR stuBLR)
        {
             this._studentBLR = stuBLR;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<StudentDTO> model = _studentBLR.GetAllStudents().ToList();
            return View("Index",model);
        }
        [HttpGet]
        public IActionResult AddEditStudent(int? id)
        {
            StudentDTO model = new StudentDTO();
            if (id.HasValue)
            {
                model = _studentBLR.GetStudent((int)id);
            }

            return PartialView("_AddEditStudent",model);
        }
        [HttpPost]
        public IActionResult AddEditStudent(StudentDTO model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _studentBLR.SaveStudent(model);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            StudentDTO model = _studentBLR.GetStudent(id);
            return PartialView("_DeteleStudent",model);
        }
        [HttpPost]
        public IActionResult DeleteStudent(int id,FormCollection form)
        {
            _studentBLR.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
