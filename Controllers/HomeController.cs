using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AtvSenac03.Models;

namespace AtvSenac03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Serviços()
        {
            return View();
        }

        public IActionResult PreAgendamento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PreAgendamento(Agendamento A)
        {
            dados.agendado.adicionar(A);
            List<Agendamento> agendar = dados.agendado.listar();
            return View("Concluido", agendar);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
