using BookingAppStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingAppStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            DbSet<Book> books =  db.Books;
            ViewBag.Books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int bookId)
        {
            ViewBag.BookId = bookId;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase p)
        {
            p.Date = DateTime.Now;
            db.Purchases.Add(p);
            db.SaveChanges();
            return p.Person + "Спасибо за покупку";
        }


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