using Pedidos;
namespace Cadeterias
{
  public class Cadete
  {
    public int Id { get; set; }
    public string Nombre { get; set; }

    public string Telefono { get; set; }



    public Cadete(int id, string nombre, string telefono)
    {
      Id = id;
      Nombre = nombre;
      Telefono = telefono;
    }
    //  public Cadete()
    // {
    //   ListaPedidos = new();
    // }

    // public void CargaPedido(Pedido pedido)
    // {
    //   ListaPedidos.Add(pedido);
    // }

    // public void CambiarEstadoPedido(int idPedido,Estados estado){
    //     foreach (var pedido in ListaPedidos)
    //     {
    //       if(pedido.Id == idPedido){
    //         pedido.CambiarEstado(estado);
    //         break;
    //       }
    //     }
    // }

    // public Pedido RemoverPedido(int id){
    //     Pedido pedido = new();
    //     for (int i = 0; i < ListaPedidos.Count; i++)
    //     {
    //       if(ListaPedidos[i].Id == id){
    //           pedido = ListaPedidos[i];
    //           ListaPedidos.Remove(ListaPedidos[i]);
    //           break;
    //       }
    //     }
    //     return pedido;

    // }


  }

}
