using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PopCorn.Services;
using Popcorn.Data;

namespace PopCorn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailService _mailService;
        private readonly MaterialsContext _context;

        public HomeController(IMailService mailService, MaterialsContext context)
        {
            _mailService = mailService;
            _context = context;
        }

        public IActionResult TRF()
        {
            var results = _context.TRFs.ToList();

            return View(results);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
