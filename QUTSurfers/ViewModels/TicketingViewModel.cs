using QUTSurfers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace QUTSurfers.ViewModels
{
    public class TicketingViewModel
    {
        public IEnumerable<Event> Trip { get; set; }
        public IEnumerable<Tshirt> ShirtSize { get; set; }
        public Ticket TicketStudent { get; set; }
    }
}