using MVC5Demo2021_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo2021_1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var data = new List<Person>()
            {
                new Person(){ Id = 1,Name = "sleeper",Age = 35},
                new Person(){ Id = 2,Name = "QQ",Age = 45},
                new Person(){ Id = 3,Name = "How",Age = 55},
                new Person(){ Id = 4,Name = "Jay",Age = 65}
            };
            return View(data);
        }
    }
}