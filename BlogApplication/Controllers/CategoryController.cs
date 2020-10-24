using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class CategoryController : Controller
    {
        BlogEntities _data = new BlogEntities();
        // GET: Category
        public ActionResult Index(string CategoryLink)
        {
            using (_data)
            {
                var q = _data.PostList.Include("CategoryList").Where(x => x.CategoryList.CategoryLink == CategoryLink).ToList();
                return View(q);
            }
        }
    }
}