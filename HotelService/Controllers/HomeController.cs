using HotelService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelService.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
          /*ViewBag.VisitorNumber = new Random().Next(1, 100);
            ViewBag.DateAndTime = DateTime.Now;
            ViewData["VisitorNumber"] = new Random().Next(1, 100);*/
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            ViewBag.Room = RoomRepository.GetRooms();
            return View();
        }
        [HttpPost]
        public ActionResult Registration(RegistrationForm model)
        {
            if (ModelState.IsValid)
            {
                return View("Success", model);
            }
            ViewBag.Room = RoomRepository.GetRooms();
            return View(model);
            
        }

    }
}
