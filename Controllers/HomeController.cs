using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.Models;
using System.Data;
using Site_Manutecao_Motos.Models;

namespace Projeto.Controllers
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

        public IActionResult Agendamento()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(AgendamentoModel agendamento){
            Console.WriteLine("Entrou no Salvar");
            return Content(agendamento.Nome + " " + 
                           agendamento.SobreNome + " " + 
                           agendamento.CPF + " " + 
                           agendamento.Email + " " + 
                           agendamento.Endereco + " " + 
                           agendamento.Cidade + " " + 
                           agendamento.Complemento + " " + 
                           agendamento.UF + " " + 
                           agendamento.Contato);
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
