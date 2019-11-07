using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Workflow_management_system.Models;

namespace Workflow_management_system.Controllers
{
     public class UsersController : Controller
     {
          private Csc502DBContext db = new Csc502DBContext();

          // GET: Users
          public ActionResult Index()
          {
               return View(db.Users.ToList());
          }

          // GET: Users/Details/5
          public ActionResult Details(string id)
          {
               if (id == null)
               {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
               }
               User user = db.Users.Find(id);
               if (user == null)
               {
                    return HttpNotFound();
               }
               return View(user);
          }

          // GET: Users/Create
          public ActionResult Create()
          {
               return View();
          }

          // POST: Users/Create
          // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
          // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Create([Bind(Include = "ID,email,password,firstname,lastname,role,level")] User user)
          {
               if (ModelState.IsValid)
               {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
               }

               return View(user);
          }

          // GET: Users/Edit/5
          public ActionResult Edit(string id)
          {
               if (id == null)
               {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
               }
               User user = db.Users.Find(id);
               if (user == null)
               {
                    return HttpNotFound();
               }
               return View(user);
          }

          // POST: Users/Edit/5
          // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
          // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Edit([Bind(Include = "ID,email,password,firstname,lastname,role,level")] User user)
          {
               if (ModelState.IsValid)
               {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
               }
               return View(user);
          }

          // GET: Users/Delete/5
          public ActionResult Delete(string id)
          {
               if (id == null)
               {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
               }
               User user = db.Users.Find(id);
               if (user == null)
               {
                    return HttpNotFound();
               }
               return View(user);
          }

          // POST: Users/Delete/5
          [HttpPost, ActionName("Delete")]
          [ValidateAntiForgeryToken]
          public ActionResult DeleteConfirmed(string id)
          {
               User user = db.Users.Find(id);
               db.Users.Remove(user);
               db.SaveChanges();
               return RedirectToAction("Index");
          }
          public ActionResult Lecturers()
          {
               IEnumerable<User> lecturers = db.Users.Where(t => t.role == "lecturer").ToList();
               return View(lecturers);
          }

          public ActionResult Assign(string id)
          {
               IEnumerable<Course> courses = db.Courses.ToList();
               User lecturer = db.Users.Where(t => t.ID == id).First();
               ViewBag.Lecturer = id;
               List<SelectListItem> allCourses = new List<SelectListItem>();
               foreach (var item in courses)
               {
                    allCourses.Add(new SelectListItem { Text = item.Code, Value = item.Code });
               }
               ViewBag.Courses = allCourses;
               return View();
          }
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Assign(CourseAssignViewModel courseassignment)
          {
               if (ModelState.IsValid)
               {
                    db.LecturerAssignments.Add(courseassignment);
                    db.SaveChanges();
                    return RedirectToAction("Lecturers");
               }

               return View();
          }
          protected override void Dispose(bool disposing)
          {
               if (disposing)
               {
                    db.Dispose();
               }
               base.Dispose(disposing);
          }
     }
}
