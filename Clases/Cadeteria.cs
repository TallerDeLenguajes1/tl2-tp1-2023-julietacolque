using Pedidos;
using Cadetes;
namespace Cadeterias
{
    public class Cadeteria
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public List<Cadete> ListaCadetes { get; set; }

        public List<Pedido> ListaPedidos { get; set; }


    }
}