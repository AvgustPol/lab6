using AntonVlasiukLab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntonVlasiukLab5.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        {
            List<Post> posts;

            using (var ctx = new BlogContext())
            {
                posts = ctx.Posts.ToList();
            }

            return View(posts);
        }

        public ActionResult Add()
        {
            return View(new Post());
        }

        [HttpPost]
        public ActionResult Add(Post post)
        {
            if(!ModelState.IsValid)
            {
                return View(post);
            }

            using (var ctx = new BlogContext())
            {
                ctx.Posts.Add(post);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Post post;

            using (var ctx = new BlogContext())
            {
                post = ctx.Posts.SingleOrDefault(p => p.Id == id);
            }

            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(int id, Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            using (var ctx = new BlogContext())
            {
                var dbEntry = ctx.Posts.SingleOrDefault(p => p.Id == id);
                dbEntry.Title = post.Title;
                dbEntry.Body = post.Body;
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var ctx = new BlogContext())
            {
                var dbEntry = ctx.Posts.SingleOrDefault(p => p.Id == id);
                ctx.Posts.Remove(dbEntry);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}