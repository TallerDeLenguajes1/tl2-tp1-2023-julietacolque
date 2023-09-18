using Pedidos;
using Cadeterias;
using CargarDatos;
using Clientes;
using Datos;

internal class Program
{
    private static void Main(string[] args)
    {
        int valor = 1, idP, idC, opcDatos;
        var cadeteria = new Cadeteria();

        do
        {
            Console.WriteLine("Como desea cargar los datos: ");
            Console.WriteLine("1-CSV ");
            Console.WriteLine("2-JSON ");
            opcDatos = Convert.ToInt32(Console.ReadLine());
        } while (opcDatos != 1 && opcDatos != 2);

        if (opcDatos == 1)
        {

            var carga = new AccesoCSV();
            cadeteria = carga.AccederCadeteria("Archivos/Cadeteria.csv",cadeteria);
         
        }
        else
        {
            var accesoJson = new AccesoJson();
            cadeteria = accesoJson.AccederCadeteria("Archivos/Cadeteria.json", cadeteria);
        }

        while (valor != 0)
        {

            Console.WriteLine("-----MENU-----\n1.Crear pedido\n2.Asignar pedido\n3.Cambiar de estado\n4.Reasignar pedido\n5.Jornal a cobrar\n6.Generar Informe\nIngrese la opcion:");
            valor = Convert.ToInt32(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.WriteLine("\nCREAR PEDIDO\n");
                    Console.WriteLine(cadeteria.AñadirPedido(CargaPedido(cadeteria)));
                    break;
                case 2:
                    Console.WriteLine("\nASIGNAR PEDIDO\n");
                    idC = SolicitarIdCadete();
                    idP = SolicitarIdPedido();
                    Console.WriteLine(cadeteria.AsignarPedido(idC, idP));
                    break;
                case 3:
                    Console.WriteLine("\nCAMBIAR ESTADO\n");
                    idP = SolicitarIdPedido();
                    Console.WriteLine(cadeteria.CambiarEstado(idP, ElegirEstado()));
                    break;
                case 4:
                    Console.WriteLine("\nREASIGNAR PEDIDO\n");
                    idC = SolicitarIdCadete(); //nuevo cadete
                    idP = SolicitarIdPedido();
                    Console.WriteLine(cadeteria.ReasignarPedido(idP, idC));
                    break;
                case 5:
                    Console.WriteLine("\nJORNAL A COBRAR CADETE \n");
                    idC = SolicitarIdCadete();
                    var cadeteBuscado = cadeteria.BuscarCadete(idC);
                    if (cadeteBuscado.Count() > 0)
                    {
                        Console.WriteLine($"\nJornal a cobrar: {cadeteria.JornalACobrar(idC)}\n");
                    }
                    break;
                case 6:
                    Console.WriteLine("\nInforme\n");
                    idC = SolicitarIdCadete();
                    Console.WriteLine(cadeteria.GenerarInforme(idC));
                    break;
            }

            Console.WriteLine("\nDesea continuar?:  ");
            valor = Convert.ToInt32(Console.ReadLine());

        }


    }

    public static int SolicitarIdCadete()
    {
        int id;
        Console.WriteLine("Ingrese el id del Cadete: ");
        id = Convert.ToInt32(Console.ReadLine());
        return id;

    }
    public static int SolicitarIdPedido()
    {
        int id;
        Console.WriteLine("Ingrese el id del pedido: ");
        id = Convert.ToInt32(Console.ReadLine());
        return id;

    }
    public static Cliente CargaCliente(Cadeteria cadeteria)
    {
        string nombre, telefono, domicilio, datos;
        Console.WriteLine("\n-.....CARGA CLIENTE.....-\n");
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

}



