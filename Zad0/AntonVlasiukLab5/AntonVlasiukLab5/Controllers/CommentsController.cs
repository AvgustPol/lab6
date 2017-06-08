using AntonVlasiukLab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntonVlasiukLab5.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Comments
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Posts");
        }

        [HttpGet]
        public ActionResult Add(int id)
        {
            Comment tmp = new Comment();

            using (var ctx = new BlogContext())
            {
               tmp.Post = ctx.Posts.Where(m => m.Id == id).FirstOrDefault();
               //ctx.SaveChanges();
            }

            return View(tmp);
        }

        [HttpPost]
        public ActionResult Add(Comment comment)
        {
            using (var ctx = new BlogContext())
            {
                comment.Post = ctx.Posts.Where(p => p.Id == comment.Post.Id).FirstOrDefault();
            
            if (!ModelState.IsValid)
            {
                return View(comment);
            }
                ctx.Comments.Add(comment);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index", "Posts");
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var ctx = new BlogContext())
            {
                var dbEntry = ctx.Comments.SingleOrDefault(m => m.Id == id);
                ctx.Comments.Remove(dbEntry);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index", "Posts");
        }


        public ActionResult Edit(int id)
        {
            Comment comment;

            using (var ctx = new BlogContext())
            {
                comment = ctx.Comments.SingleOrDefault(p => p.Id == id);
            }

            return View(comment);
        }

        [HttpPost]
        public ActionResult Edit(int id, Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return View(comment);
            }

            using (var ctx = new BlogContext())
            {
                var dbEntry = ctx.Comments.SingleOrDefault(p => p.Id == id);
                dbEntry.Content = comment.Content;
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}