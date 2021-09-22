using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkpoint.Models;

namespace Checkpoint.Controllers
{
    public class EmbarcacaoController : Controller
    {

        private static IList<Embarcacao> _lista = new List<Embarcacao>();

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Embarcacao embarcacao)
        {

            //ViewBag.embarcacao = embarcacao;
            if (embarcacao.Nome == null)
            {
                TempData["Erro"] = "Erro ao registrar a embarcação, veja se os campos informados estão corretos.";
            }
            else
            {
                TempData["Sucesso"] = $"A embarcação {embarcacao.Nome} foi cadastrada!";
                _lista.Add(embarcacao);
            }
            return RedirectToAction("Cadastrar");
        }



        public IActionResult Alterar()
        {
            return View();
        }


        public IActionResult Deletar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Listagem()
        {
            return View(_lista);
        }
    }
}
