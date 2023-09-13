using Pedidos;
using Cadetes;
using Clientes;
namespace Cadeterias
{
    public class Cadeteria
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public List<Cadete> ListaCadetes { get; set; }

        public Cadeteria()
        {

            ListaCadetes = new();
        }

        public Cadeteria(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
            ListaCadetes = new();
        }
        public Cliente CrearCliente(string nombre, string telefono, string domicilio, string datosRef)
        {
            Cliente cliente = new(nombre, telefono, domicilio, datosRef);
            return cliente;
        }
        public Pedido CrearPedido(int id, string obs, Cliente cliente)
        {
            var pedido = new Pedido(id, obs, cliente);
            return pedido;
        }
        public string AsignarPedido(int idCadete, Pedido pedido)
        {
           string respuesta = "Algo fallo el pedido no fue asignado";
            foreach (var cadete in ListaCadetes)
            {
                if (idCadete == cadete.Id)
                {   
                    respuesta  = "Asignado con exito";
                    cadete.CargaPedido(pedido);
                }
            }
            return respuesta;
        }

        public string CambiarEstado(int idPedido, int idCadete, Estados estado)
        {
            string res = "pedido o cadete no encontrado";
            foreach (var cadete in ListaCadetes)
            {
                if (cadete.Id == idCadete)
                {
                    cadete.CambiarEstadoPedido(idPedido, estado);
                    res = $"El estado del pedido {idPedido} ha sido modificado";
                    break;
                }
            }
            return res;
        }
        public string ReasignarPedido(int idPedido, Cadete cadete, int idCadeteNuevo)

        // BUSCAR UN CADETE PRIMERO ES DECIR EN EL MAIN DEBO PREGUNTAR CUAL ES EL ID DEL CADETE AL QUE LE QUIERO SACAR EL PEDIDO.
        {
            
            string respuesta = AsignarPedido(idCadeteNuevo, cadete.RemoverPedido(idPedido));
            return respuesta;

        }

        public void CargarCadete(Cadete cadete)
        {
            ListaCadetes.Add(cadete);
        }

        public List<Cadete> BuscarCadete(int idCadete){
            var cadetes = ListaCadetes.Where(x=>x.Id == idCadete).ToList();
            return cadetes;

        }
    }
}

/*
Cadeteria.CrearPedido(parametros de pedido)
Cadeteria.AsignarPedido(idCadete, idPedido)
*/