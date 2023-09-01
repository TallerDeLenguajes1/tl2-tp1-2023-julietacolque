using Clientes;
namespace Pedidos
{
  public class Pedido
  {
    public int Id { get; set; }
    public string Observacion { get; set; }

    public Cliente Cliente { get; set; }

    public Estados Estado { get; set; }

    public Pedido(int id,string observacion, Cliente cliente){
      Id = id;
      Observacion = observacion;
      Cliente = cliente;
      Estado = Estados.EnCurso;
    }
  }
}
public enum Estados
{
  EnCurso,
  Entregado,
  Cancelado
}