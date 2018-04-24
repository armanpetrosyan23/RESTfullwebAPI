using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIFreeman.Models;

namespace WebAPIFreeman.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository { get; set; }
        public HomeController(IRepository rep)
        {
            repository = rep;
        }
        public ViewResult Index()
        {
            return View(repository.Reservations);
        }

        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            repository.AddReservation(reservation);
            return RedirectToAction("Index");

        }
    }
}
