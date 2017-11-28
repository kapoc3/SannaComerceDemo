using SannaComerce.Services.Logic.Services;
using SannaComerceDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SannaComerceDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Product.repositorySource == null)
            {
                Product.repositorySource = "Memory";
            }

            var model = new ConectionModel();
            model.Source = Product.repositorySource;

            return View("Index",model);
        }

        public ActionResult ChangeSource()
        {
            if (Product.repositorySource.Equals("Memory"))
            {
                Product.repositorySource = "Sql";
            }
            else
            {
                Product.repositorySource = "Memory";
            }

            return RedirectToAction("Index");
        }
    }
}