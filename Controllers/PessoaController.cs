using CRUDBasicCSharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDBasicCSharp.Controllers
{
    public class PessoaController : Controller
    {
        public Pessoa _pessoa = new Pessoa();
        public IActionResult Index()
        {
            var pessoaList = _pessoa.ObterPessoas();
            return View(pessoaList);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Alterar(string id)
        {
            var pessoa = _pessoa.ObterPessoa(id);
            return View(pessoa);
        }

        public IActionResult Inserir(Pessoa pessoa)
        {
            var result = _pessoa.Inserir(pessoa);
            return RedirectToAction("Index", "Pessoa");
        }

        public IActionResult Atualizar(Pessoa pessoa)
        {
            var result = _pessoa.Atualizar(pessoa);
            return RedirectToAction("Index", "Pessoa");
        }

        public IActionResult Visualizar(string id)
        {
            var pessoa = _pessoa.ObterPessoa(id);
            return View(pessoa);
        }
        public IActionResult MostrarExcluir(string id)
        {
            var pessoa = _pessoa.ObterPessoa(id);
            return View("Views/Pessoa/Excluir.cshtml",pessoa);
        }
        public IActionResult Excluir(Pessoa pessoa)
        {
            var result = _pessoa.Excluir(pessoa);
            return RedirectToAction("Index", "Pessoa");
        }
    }
}
