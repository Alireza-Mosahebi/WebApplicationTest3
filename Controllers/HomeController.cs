using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationTest3.Models;

namespace WebApplicationTest3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperationModel model, string command)
        {
            if (command == "Add") {
                model.Result = model.FirstNumber + model.SecondNumber;
            }
            if (command == "Subtract") {
                model.Result = model.FirstNumber - model.SecondNumber;
            }
            if (command == "Muliply") {
                model.Result = model.FirstNumber * model.SecondNumber;
            }
            if (command == "Divid") {
                model.Result = model.FirstNumber / model.SecondNumber;
            }
            return View(model);
        }

    }
}