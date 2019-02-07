using QUTSurfers.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using QUTSurfers.ViewModels;

namespace QUTSurfers.Controllers
{
    public class TicketsController : Controller
    {
        // GET: Tickets
        public ActionResult TicketForm()
        {
            var tshirt = GetTshirtInfo();
            var trip = GetTripInfo();
            var student = new Ticket ();

            var viewModel = new TicketingViewModel
            {
                TicketStudent = student,
                Trip = trip,
                ShirtSize = tshirt
            };
            return View(viewModel);
        }



        private IEnumerable<Event> GetTripInfo()
        {
            return new List<Event>
            {
                new Event { Id=1, Name = "Byron-Bay Trip 1"},
                new Event { Id=2, Name="Byron-Bay Trip 2"},
                new Event { Id=3, Name="Byron-Bay Trip 3"}
            };
        }

        private IEnumerable<Tshirt> GetTshirtInfo()
        {
            return new List<Tshirt>
            {
                new Tshirt { Id= 1, Color = "White", Size="S"},
                new Tshirt { Id= 2, Color = "White", Size="M"},
                new Tshirt { Id= 3, Color = "White", Size="L"},
                new Tshirt { Id= 4, Color = "White", Size="XL"},
                new Tshirt { Id= 5, Color = "Black", Size="S"},
                new Tshirt { Id=6, Color = "Black", Size="M"},
                new Tshirt { Id= 7, Color = "Black", Size="L"},
                new Tshirt { Id= 8, Color = "Black", Size="XL"}

            };
        }
    }
}