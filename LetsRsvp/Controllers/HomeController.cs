using LetsRsvp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRsvp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Confirmar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirmar(Confirmacao confirmacao)
        {

            //if (confirmacao.Confirmado != null)
            if (ModelState.IsValid)
            {
                Repositorio.AdicionaConfirmacao(confirmacao);
                return RedirectToAction("Index");
            }

            return View(confirmacao);
        }

        public IActionResult Confirmados()
        {
            var confirmados = Repositorio.Confirmacoes.Where(x => x.Confirmado == true);

            return View(confirmados);
        }
    }
}
