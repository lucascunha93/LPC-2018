using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppHostingMvc.Models;

namespace AppHostingMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var car = new CartaoDeCredito();
            List<Gerente> gerentes = new List<Gerente>();
            
            gerentes.Add(new Gerente { id=1, nome = "Adri" });
            gerentes.Add(new Gerente {id = 2, nome = "Ramon" });

            return View(gerentes);


        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
