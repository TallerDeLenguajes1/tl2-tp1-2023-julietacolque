using Cadetes;
using Pedidos;
using Cadeterias;
using Cargas;
internal class Program
{
    private static void Main(string[] args)
    {
        Pedido pedido1 = new();
        Cadete cadete = new();
        Cadeteria cadeteria = new();
        Cargar carga = new();
        carga.Pedidos();


        pedido1.Id = 1;
        pedido1.Observacion = "calle";
        pedido1.Cliente.Nombre = "Julieta";
        pedido1.Cliente.Telefono = "3876579299";
        pedido1.Cliente.Domicilio = "Avellaneda 621";

       cadete.Id = 1;
       cadete.Nombre = "juan";
       cadete.Telefono ="dasdas";

       AgregarCadete(cadeteria,cadete); //agregue un cadete en la cadeteria
       AgregarPedido(cadeteria, pedido1); //agregue un pedido en la lista de pedidos de la cadeteria.

       //buscar a quien asigno el pedido, puede ser al cadete menos ocupado 
    }


    public static void AgregarCadete(Cadeteria cadeteria, Cadete cadete)
    {
        cadeteria.ListaCadetes.Add(cadete);
    }
    public static void AgregarPedido(Cadeteria cadeteria, Pedido pedido){
        cadeteria.ListaPedidos.Add(pedido);
    }

    public static void AsignarPedido(int idCadete,List<Cadete>listaCadete,Pedido pedido){

        foreach (var cadete in listaCadete)
        {
            if(cadete.Id == idCadete){
                cadete.ListaPedidos.Add(pedido);
                
            }
        }


    }
    public static void EliminarPedido(List<Pedido> listaPedidos, int id)
    {
        foreach (var pedido in listaPedidos)
        {
            if (pedido.Id == id)
            {
                listaPedidos.Remove(pedido);
            }
        }
    }
    
}