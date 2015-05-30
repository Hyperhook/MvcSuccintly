using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSuccintly.Models;

namespace MvcSuccintly.Controllers
{
    public class ItineraryController : Controller
    {
        //
        // GET: /Itinerary/
        [HttpGet]
        public ActionResult Create()
        {
            var model = new ItineraryItem();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(ItineraryItem data)
        {
            if(ModelState.IsValid)
            {

            }
            else
            {
                ModelState.AddModelError("", "The data is invalid");
            }
            return View();
        }

    }
}
