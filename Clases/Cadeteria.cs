using Pedidos;
using Cadetes;
namespace Cadeterias
{
    public class Cadeteria
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public List<Cadete> ListaCadetes { get; set; }


        public Cadeteria(string nombre, string telefono){
            Nombre = nombre;
            Telefono = telefono;
            ListaCadetes = new();
        }

        public void AsignarPedido(int idCadete, Pedido pedido){
            foreach (var cadete in ListaCadetes)
            {
                if(idCadete == cadete.Id){
                    cadete.CargaPedido(pedido);
                }
            }
        }
    }
}