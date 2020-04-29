using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using profitadmin.Models;

namespace profitadmin.Controllers
{
    public class Colaborador : Controller
    {
        private readonly ILogger<Colaborador> _logger;

        public Colaborador(ILogger<Colaborador> logger)
        {
            _logger = logger;
        }

        public IActionResult Detalhe( int? id)
        {
            return View("Colaborador");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
