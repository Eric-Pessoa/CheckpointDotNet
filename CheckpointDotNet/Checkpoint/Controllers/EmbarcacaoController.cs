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

        private static List<Embarcacao> _lista = new List<Embarcacao>();
        private static List<Embarcacao> _listaNova = new List<Embarcacao>();
        private static int _index = 0;

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
            if (embarcacao.Nome == null)
            {
                TempData["Erro"] = "Erro ao registrar a embarcação, veja se os campos informados estão corretos.";
            }
            else
            {
                TempData["Sucesso"] = $"A embarcação {embarcacao.Nome} foi cadastrada!";
                embarcacao.Id = ++_index;
                _lista.Add(embarcacao);
            }
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            Embarcacao embarcacao = _lista.Find(embarcacao => embarcacao.Id == id);
            return View(embarcacao);
        }

        [HttpPost]
        public IActionResult Alterar(Embarcacao embarcacao)
        {

            if (embarcacao.Nome == null)
            {
                TempData["Erro"] = "Erro ao alterar dados da embarcação, veja se os campos informados estão corretos.";
            }
            else
            {
                TempData["Sucesso"] = $"A embarcação {embarcacao.Nome} foi alterada!";
                _lista[_lista.FindIndex(p => p.Id == embarcacao.Id)] = embarcacao;


            }
            return RedirectToAction("Alterar");
        }

        [HttpPost]
        public IActionResult Deletar(int Id)
        {
            int posLista = _lista.FindIndex(p => p.Id == Id);
            _lista.RemoveAt(posLista);
            TempData["Sucesso"] = $"A embarcação foi deletada!";
            return RedirectToAction("Listagem");
        }

        [HttpGet]
        public IActionResult Listagem()
        {
            int count = _listaNova.Count;

            if(count == 0)
            {
                return View(_lista);
            } else
            {
                List<Embarcacao> temp = new List<Embarcacao>();
                foreach(var item in _listaNova)
                {
                    temp.Add(item);
                }
                _listaNova.Clear();
                return View(temp);
            }
        }

        [HttpPost]
        public IActionResult Listagem(string nome)
        {
            _listaNova = _lista.FindAll(p => p.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));
            int count = _listaNova.Count;
            if (count == 0)
            {
                TempData["Erro"] = "Não achamos nenhuma embarcação com esse nome!";
            }
                return RedirectToAction("Listagem");
        }
    }
}
