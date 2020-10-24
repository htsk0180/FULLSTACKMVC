using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class HomeController : Controller
    {
        BlogEntities _data = new BlogEntities();

        // GET: Home
        public ActionResult Index()
        {
            using (_data)
            {
                ViewBag.Articles = _data.PostList.ToList();
            }
            return View();
        }

        public PartialViewResult CategoryPartial()
        {

            using (_data)
            {
                return PartialView(_data.CategoryList.ToList());
            }

        }


        public ActionResult Detail(string PostLink)
        {
            using (_data)
            {
                var q = _data.PostList.Include("CategoryList").SingleOrDefault(x => x.PostLink == PostLink);
                if (q != null)
                {
                    return View(q);
                }
            }

            return View();
        }


        public ActionResult Hakkimda() {

            return View();
        }
    }
}