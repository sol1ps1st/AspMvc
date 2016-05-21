using ControllersBasic.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersBasic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View("~/Views/Some/Index.cshtml");
            ViewData["Head"] = "привет";
            List<string> fruits = new List<string>() { "яблоко", "груша", "банан" };
            ViewBag.Fruits = fruits;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public string GetId(int id)
        {
            return id.ToString();
        }

        public string Square(int a, int b)
        {
            return (a * b).ToString();
        }
        [HttpGet]
        public ActionResult GetBook()
        {
            return View();
        }

        [HttpPost]
        public string PostBook()
        {
            string title = Request.Form["title"];
            string author = Request.Form["author"];
            return String.Format("<h2>{0} {1}</h2>", title, author);
        }

        public ContentResult SquareNo()
        {
            int a = int.Parse(Request.Params["a"]);
            int b = int.Parse(Request.Params["b"]);
            return Content((a + b).ToString());
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult GetHtml()
        {
            HtmlResult hr = new HtmlResult("<h2>Привет мир!</h2>");
            hr.ExecuteResult(this.ControllerContext);
            return hr;
        }

        //public ActionResult GetImage(string path)
        public ActionResult GetImage()
        {
            string path = "../Content/Images/son.jpg";
            //string path = "~/Content/Images/son.jpg";
            return new ImageResult(path);
        }

        public ActionResult Get404()
        {
            return new HttpStatusCodeResult(404);
        }

    }
}