using static System.Console;

// uso de Datas em Objetos
using DatasEmObjetos;

var pedido = new Pedido
{
    PedidoID = 1,
    DtPedido = DateTime.Today,
    DtPagto = DateTime.Today.AddDays(45),
    Valor = 1500
};

WriteLine($"Pedido: {pedido.PedidoID} - {pedido.DtPedido:dd/MMM/yyyy} - vencto: {pedido.DtVencimento():dd/MMM/yyyy} - " +
          $"dias atraso: {pedido.DiasAtraso().TotalDays} - valor: {pedido.Valor:n2} - multa: {pedido.Multa:n2}");

ReadKey();
