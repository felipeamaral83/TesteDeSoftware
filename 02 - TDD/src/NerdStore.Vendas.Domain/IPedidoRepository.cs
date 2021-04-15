using NerdStore.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Domain
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<IEnumerable<Pedido>> ObterListaPorClienteId(Guid clienteId);
        void Adicionar(Pedido pedido);
        void Atualizar(Pedido pedido);
        void AdicionarItem(PedidoItem pedidoItem);
        void AtualizarItem(PedidoItem pedidoItem);
        void RemoverItem(PedidoItem pedidoItem);
        Task<Pedido> ObterPedidoRascunhoPorClienteId(Guid clienteId);
        Task<PedidoItem> ObterItemPorPedido(Guid pedidoId, Guid produtoId);
        Task<Voucher> ObterVoucherPorCodigo(string codigo);
    }
}
