using Clientes;
namespace Pedidos
{
  public class Pedido
  {
    public int Id { get; set; }
    public string Observacion { get; set; }

    public Cliente Cliente { get; set; }

    public Estados Estado { get; set; }

    //constructor
    public Pedido(int id,string observacion, Cliente cliente){
      Id = id;
      Observacion = observacion;
      Cliente = cliente;
      Estado = Estados.EnCurso;
    }

    public Pedido(){
      
    }

     public string DireccionCliente(){
      return Cliente.Domicilio;
     }
     public string VerDatosCliente(){
      return Cliente.DatosReferenciaDireccion;
     }

     public void CambiarEstado(Estados estado){
          Estado = estado;
     }
  }
}
public enum Estados
{
  EnCurso,
  Entregado,
  Cancelado
}