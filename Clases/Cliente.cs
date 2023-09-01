namespace Clientes
{
    public class Cliente
    {
        public Cliente(string nombre, string telefono, string domicilio)
        {
            Nombre = nombre;
            Telefono = telefono;
            Domicilio = domicilio;
        }

        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public string Domicilio { get; set; }


    }
}