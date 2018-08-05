using BeckonedPathx.Client.Data;
using BeckonedPathx.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BeckonedPathx.Client.Controllers
{
    public class HomeController : Controller
    {
        private BeckonedContext db = new BeckonedContext();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostFeed()
        {
            return View(db.Posts.ToList());
            //return View();
        }


        public ActionResult PostDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var post = db.Posts.Include("Comments").SingleOrDefault(p => p.PostId == id);//.ToList();
            ViewBag.asd = post;
            //var post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost]
        public ActionResult PostDetails(Post iono)
        {
            return RedirectToAction("ViewPage1", iono);
            //return RedirectToAction("ViewPage1", iono); localhost:50153/Home/ViewPage1?PostId=1&CreatedDate=08%2F01%2F2018%2000%3A00%3A00&EventDate=08%2F01%2F2019%2000%3A00%3A00&UserId=1
        }

        public ActionResult ViewPage1(Post iono)
        {
            ViewBag.pdeets = iono;
            return View();
        }
        // GET: Post/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Post post = db.Posts.Find(id);
        //    if (post == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(post);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}