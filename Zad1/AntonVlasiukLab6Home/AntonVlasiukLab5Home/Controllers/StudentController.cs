using AntonVlasiukLab5Home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntonVlasiukLab5Home.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students;

            using (var ctx = new SchoolContext())
            {
                students = ctx.Students.ToList();
            }

            return View(students);
        }

        public ActionResult Add()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Add(Student post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            using (var ctx = new SchoolContext())
            {
                ctx.Students.Add(post);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var ctx = new SchoolContext())
            {
                var dbEntry = ctx.Students.SingleOrDefault(m => m.Id == id);
                ctx.Students.Remove(dbEntry);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Student student;

            using (var ctx = new SchoolContext())
            {
                student = ctx.Students.SingleOrDefault(m => m.Id == id);
            }

            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            using (var ctx = new SchoolContext())
            {
                var dbEntry = ctx.Students.SingleOrDefault(p => p.Id == id);
                dbEntry.FirstName = student.FirstName;
                dbEntry.LastName = student.LastName;
                dbEntry.Age = student.Age;
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}