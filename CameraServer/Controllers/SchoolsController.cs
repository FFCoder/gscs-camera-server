using System;
using System.Collections.Generic;
using System.Linq;
using CameraServer.Data;
using CameraServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CameraServer.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SchoolController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET
        [Authorize(Policy = "RequireTechnician")]
        public ActionResult Index()
        {
            Console.WriteLine("Schools Index Called!");
            var schools = _context.Schools.OrderByDescending(s => s.SchoolId).Take(25).ToList();
            return View(schools);
        }

        [Authorize(Policy = "RequireTechnician")]
        public IActionResult Edit(int id)
        {
            var school = _context.Schools.FirstOrDefault(s => s.SchoolId == id);
            return View(school);

        }
        [Authorize(Policy = "RequireTechnician")]
        [HttpPost]
        public IActionResult Edit(School school)
        {
            
            var oldSchoolData = _context.Schools.FirstOrDefault(s => s.SchoolId == school.SchoolId);
            _context.Schools.Remove(oldSchoolData);
            _context.Schools.Add(school);
            

            return RedirectToAction("Index");
        }
    }
}