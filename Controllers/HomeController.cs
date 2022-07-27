using Microsoft.AspNetCore.Mvc;
using ProjetoFormulario.Models;
using System.Diagnostics;

namespace ProjetoFormulario.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            //apresenta menu inicial
            return View();
        }

        public IActionResult listaClientes()
        {
            //apresenta a lista de clientes da aplicação
            return View(Dados.todosOsClientes());
        }

        public IActionResult adicionarClientes()
        {
            //adicionar um novo cliente
            return View();
        }
        [HttpPost]
        public IActionResult adicionarCliente(Cliente cliente)
        {
            //guardar os dados do novo cliente
            Dados.adicionarCliente(cliente);
            return RedirectToAction("adicionarClientes");
        }

        public IActionResult editarCliente(int id)
        {
            return View(Dados.dadosCliente(id));
        }

        [HttpPost]
        public IActionResult editarCliente(Cliente cliente)
        {
            Dados.editarCliente(cliente);
            return RedirectToAction("listaClientes");
        }

        public IActionResult excluirCliente(int id)
        {
            //exclui cliente selecionado
            Dados.excluirCliente(id);
            return RedirectToAction("listaClientes");
        }
    }
}