using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class AdminController : Controller
    {
        BlogEntities _data = new BlogEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Giris(string kullaniciadi, string sifre)
        {
            using (_data)
            {
                var q = _data.UserList.SingleOrDefault(x => x.KullaniciAdi == kullaniciadi && x.Sifre == sifre);
                if (q != null)
                {
                    Session["Giris"] = q;
                    return RedirectToAction("Dashboard");
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult KategoriEkle()
        {
            using (_data)
            {
                ViewBag.categorylist = _data.CategoryList.ToList();
            }
            return View();
        }


        public ActionResult KategoriAdd(string CategoryName, string CategoryLink, string TopCategory)
        {

            using (_data)
            {
                var TopCat = int.Parse(TopCategory ?? "0");
                _data.CategoryList.Add(new CategoryList() { CategoryName = CategoryName, CategoryLink = CategoryLink, TopCategory = TopCat });
                _data.SaveChanges();
            }

            return RedirectToAction("Dashboard");
        }

        public ActionResult YaziEkle()
        {
            using (_data)
            {
                ViewBag.categorylist = _data.CategoryList.ToList();
            }
            return View();
        }


        public ActionResult YaziAdd(string PostHeader, string PostBody, string PostLink, string TopCategory)
        {
            using (_data)
            {
                var TopCat = int.Parse(TopCategory ?? "0");
                _data.PostList.Add(new PostList() { PostHeader = PostHeader, PostBody = PostBody, PostLink = PostLink, CategoryId = TopCat, PostDate = DateTime.Now });
                _data.SaveChanges();

            }
            return RedirectToAction("Dashboard");
        }

    }
}