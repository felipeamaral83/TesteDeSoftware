using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdStore.Vendas.Domain
{
    public class Pedido
    {
        public Pedido()
        {
            _pedidoItens = new List<PedidoItem>();
        }

        private readonly List<PedidoItem> _pedidoItens;
        public IReadOnlyCollection<PedidoItem> PedidoItens => _pedidoItens;

        public decimal ValorTotal { get; private set; }

        public void AdicionarItem(PedidoItem pedidoItem)
        {
            _pedidoItens.Add(pedidoItem);
            ValorTotal = PedidoItens.Sum(i => i.Quantidade * i.ValorUnitario);
        }
    }

    public class PedidoItem
    {
        public Guid ProdutoId { get; private set; }
        public string ProdutoNome { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }

        public PedidoItem(Guid produtoId, string produtoNome, int quantidade, decimal valorUnitario)
        {
            ProdutoId = produtoId;
            ProdutoNome = produtoNome;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }
    }
}