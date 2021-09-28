using LetsRsvp.Models;
using LetsRsvp.ViewModels;
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
        private readonly IRepositorio _repositorio;

        public HomeController(ILogger<HomeController> logger, IRepositorio repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
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

            if (ModelState.IsValid)
            {
                _repositorio.AdicionaConfirmacao(confirmacao);
                return RedirectToAction("Index");
            }

            return View(confirmacao);
        }

        public IActionResult Confirmados()
        {
            var viewModel = new ConfirmadosViewModel()
            {
                Confirmados = _repositorio.Confirmacoes,
                Search = string.Empty
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Confirmados(ConfirmadosViewModel viewModel)
        {
            viewModel.Confirmados = _repositorio.Confirmacoes;

            return View(viewModel);
        }


        public IActionResult NumeroDeConvidados()
        {
            var confirmados = _repositorio.Confirmacoes.Where(x => x.Confirmado == true);
            return View(confirmados);
        }


        public IActionResult Edicao(int id)
        {
            var editando = _repositorio.Confirmacoes.FirstOrDefault(x => x.Id == id);
            if (editando == null)
                return RedirectToAction("Confirmados");

            return View(editando);
        }

        [HttpPost]
        public IActionResult Edicao(Confirmacao confirmacao)
        {
            _repositorio.Update(confirmacao);

            return RedirectToAction("Confirmados");
        }
    }
}