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
            var data = new List<PersonModel>()
            {
                new PersonModel(){ Id = 1, Name="sleeper",Age = 35},
                new PersonModel(){ Id = 2, Name ="QQ", Age=35},
                new PersonModel(){ Id =3,Name = "how",Age = 35}
            };


            return View(data);
        }
    }
}