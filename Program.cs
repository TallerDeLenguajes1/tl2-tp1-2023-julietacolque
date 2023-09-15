using Cadetes;
using Pedidos;
using Cadeterias;
using CargarDatos;
using Clientes;
internal class Program
{
    private static void Main(string[] args)
    {
        int valor = 1, id, idPedido;
        var carga = new CargarDato();
        var cadeteria = carga.Datos("Archivos/Cadeteria.csv");
        carga.CargarCadetes("Archivos/Cadete.csv", cadeteria);



        while (valor != 0)
        {

            Console.WriteLine("-----MENU-----\n1.Asignar pedido\n2.Cambiar de estado\n3.Reasignar pedido\n4.Jornal a cobrar\n5.Generar Informe\nIngrese la opcion:");
            valor = Convert.ToInt32(Console.ReadLine());

            switch (valor)
            {

                case 1:
                    Console.WriteLine("\nASIGNAR PEDIDO\n");
                    Console.WriteLine("Ingrese el id del cadete: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(cadeteria.AsignarPedido(id, CargaPedido(cadeteria)));
                    break;
                case 2:
                    Console.WriteLine("\nCAMBIAR ESTADO\n");
                    Console.WriteLine("Ingrese el id del Cadete: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nIngrese el id del Pedido: ");
                    idPedido = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(cadeteria.CambiarEstado(idPedido, id, ElegirEstado()));
                    break;
                case 3:
                    Console.WriteLine("\nREASIGNAR PEDIDO\n");

                    Console.WriteLine(ReasignacionPedido(cadeteria));
                    break;
                case 4:
                    Console.WriteLine("\nJORNAL A COBRAR CADETE \n");
                    Console.WriteLine("Ingrese el id del Cadete: ");
                    id = Convert.ToInt32(Console.ReadLine());
                     var cadeteBuscado = cadeteria.BuscarCadete(id);
                     if(cadeteBuscado.Count()>0){
                       Console.WriteLine($"\nJornal a cobrar: {cadeteBuscado[0].JornalACobrar()}\n");
                     }
                    break;
                case 5: Console.WriteLine("\nInforme\n");
                        Console.WriteLine(cadeteria.GenerarInforme());
                break;
            }

            Console.WriteLine("\nDesea continuar?:  ");
            valor = Convert.ToInt32(Console.ReadLine());

        }


    }

    public static Cliente CargaCliente(Cadeteria cadeteria)
    {
        string nombre, telefono, domicilio, datos;
        System.Console.WriteLine("\n-.....CARGA CLIENTE.....-\n");
        Console.WriteLine("Nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("\nTelefono:");
        telefono = Console.ReadLine();
        Console.WriteLine("\nDomicilio: ");
        domicilio = Console.ReadLine();
        Console.WriteLine("\nDatos: ");
        datos = Console.ReadLine();
        return cadeteria.CrearCliente(nombre, telefono, domicilio, datos);


    }

    public static Pedido CargaPedido(Cadeteria cadeteria)
    {
        int id; string obs;
        Console.WriteLine("\n-----Datos del pedido-----");
        Console.WriteLine("ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nObservacion: ");
        obs = Console.ReadLine();
        Console.WriteLine("Creando pedido....");
        return cadeteria.CrearPedido(id, obs, CargaCliente(cadeteria));

    }

    public static Estados ElegirEstado()
    {

        int respuesta;
        Console.WriteLine("\nA que estado desea cambiar el pedido:\n ");
        Console.WriteLine("1-Cancelado\n2-Realizado\n");
        respuesta = Convert.ToInt32(Console.ReadLine());
        if (respuesta == 1)
        {
            return Estados.Cancelado;

        }
        else
        {
            return Estados.Entregado;
        }


    }
    public static string ReasignacionPedido(Cadeteria cadeteria)
    {
        int id, idPedido;
        List<Cadete> cadete;
        do
        {
            Console.WriteLine("\nIngrese el id del Cadete para remover el pedido: ");
            id = Convert.ToInt32(Console.ReadLine());
            cadete = cadeteria.BuscarCadete(id);
        }

        while (cadete.Count() == 0);


        Console.WriteLine("\nIngrese el id del NUEVO Cadete: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nIngrese el id del Pedido: ");
        idPedido = Convert.ToInt32(Console.ReadLine());

        return cadeteria.ReasignarPedido(idPedido, cadete[0], id);

    }
}



