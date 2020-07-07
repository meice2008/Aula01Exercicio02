using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula01Exercicio02.DAO;
using Aula01Exercicio02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula01Exercicio02.Controllers
{
    //Meice Silva de Jesus
    public class PedidoController : Controller
    {
        private readonly PedidoDAO _pedidoDAO;
        public PedidoController(PedidoDAO pedidoDAO)
        {
            _pedidoDAO = pedidoDAO;
        }

        public IActionResult Index()
        {
            ViewBag.Data = DateTime.Now;
            return View(_pedidoDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Pedido pedido)
        {
            _pedidoDAO.Cadastrar(pedido);
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int id)
        {
            _pedidoDAO.Remover(_pedidoDAO.BuscarPorId(id));
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int id)
        {
            return View(_pedidoDAO.BuscarPorId(id));
        }
        [HttpPost]
        public IActionResult Alterar(Pedido pedido)
        {
            _pedidoDAO.Alterar(pedido);
            return RedirectToAction("Index");
        }
    }
}