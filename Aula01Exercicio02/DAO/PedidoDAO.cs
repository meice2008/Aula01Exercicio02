using Aula01Exercicio02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01Exercicio02.DAO
{
    public class PedidoDAO
    {
        private readonly Context _context;
        public PedidoDAO(Context context)
        {
            _context = context;

        }

        public void Cadastrar(Pedido p)
        {
            _context.Pedidos.Add(p);
            _context.SaveChanges();
        }
        public List<Pedido> Listar()
        {
            return _context.Pedidos.ToList();
        }
        public void Remover(Pedido p)
        {
            _context.Pedidos.Remove(p);
            _context.SaveChanges();
        }
        public void Alterar(Pedido p)
        {
            _context.Pedidos.Update(p);
            _context.SaveChanges();
        }
        public Pedido BuscarPorId(int id)
        {
            return _context.Pedidos.Find(id);
        }
    }
}
