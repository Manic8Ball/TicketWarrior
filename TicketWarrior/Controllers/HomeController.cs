using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketWarrior.Models;

namespace TicketWarrior.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            return View();
        }


        [HttpGet]
        public ViewResult ConcertForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ConcertForm(TicketResponse ticketResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party organizer
                return View("Thanks", ticketResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}
