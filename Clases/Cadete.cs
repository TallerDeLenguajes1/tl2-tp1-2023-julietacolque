using Pedidos;
namespace Cadetes
{
  public class Cadete
  {
    public int Id { get; set; }
    public string Nombre { get; set; }

    public string Telefono { get; set; }

    public List<Pedido> ListaPedidos { get; set; }

    public Cadete(int id, string nombre, string telefono)
    {
      Id = id;
      Nombre = nombre;
      Telefono = telefono;
      ListaPedidos = new();
    }
    //  public Cadete()
    // {
    //   ListaPedidos = new();
    // }

    public void CargaPedido(Pedido pedido)
    {
      ListaPedidos.Add(pedido);
    }

    public void CambiarEstadoPedido(int idPedido,Estados estado){
        foreach (var pedido in ListaPedidos)
        {
          if(pedido.Id == idPedido){
            pedido.CambiarEstado(estado);
            break;
          }
        }
    }

    public Pedido RemoverPedido(int id){
        Pedido pedido = new();
        for (int i = 0; i < ListaPedidos.Count; i++)
        {
          if(ListaPedidos[i].Id == id){
              pedido = ListaPedidos[i];
              ListaPedidos.Remove(ListaPedidos[i]);
              break;
          }
        }
        return pedido;
       
    }
    public float JornalACobrar()
    {
      float jornal = 500;
      int entregaRealizada = 0;
      foreach (var pedido in ListaPedidos)
      {
        if (pedido.Estado == Estados.Entregado)
        {
          entregaRealizada++;
        }
      }

      return jornal * entregaRealizada;
    }
  }

}
