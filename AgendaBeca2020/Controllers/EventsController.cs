using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaBeca2020.Data;
using Microsoft.AspNetCore.Mvc;

namespace AgendaBeca2020.Controllers
{
    public class EventsController : Controller
    {
        private readonly DataContext _context;

        public EventsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var events = _context.Events.ToList();
            ViewBag.Events = events;
            return View();
        }
    }
}