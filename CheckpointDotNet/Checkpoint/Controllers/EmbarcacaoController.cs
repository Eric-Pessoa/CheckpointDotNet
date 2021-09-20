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
            string nome = embarcacao.Nome;
            double milhas = embarcacao.MilhasNavegadas;
            int condicao = embarcacao.Condicao;
            int porte = embarcacao.Porte;
            bool turistico = embarcacao.Turistico;
            ViewData["msg"] = $"A embarcação {embarcacao.Nome} foi cadastrada!";
            return View();
        }



        public IActionResult Alterar()
        {
            return View();
        }


        public IActionResult Deletar()
        {
            return View();
        }


        public IActionResult Listagem()
        {
            return View();
        }
    }
}
