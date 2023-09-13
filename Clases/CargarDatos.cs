using System.Numerics;
using Cadeterias;
using Cadetes;
namespace CargarDatos
{
    public class CargarDato
    {
        public Cadeteria Datos(string path)
        {
            string linea, delimitador = ",";
            var cadeteria = new Cadeteria();
            if (File.Exists(path))
            {
                using (var archivo = new FileStream(path, FileMode.Open))
                {
                    using (var sr = new StreamReader(archivo))
                    {
                        linea = sr.ReadLine(); //primera linea
                        linea = sr.ReadLine();
                        if (linea != null)
                        {
                            // a esta linea la separo 
                            string[] cadena = linea.Split(delimitador);
                            cadeteria.Nombre = cadena[0];
                            cadeteria.Telefono = cadena[1];
                        }

                    }

                }
            }
            return cadeteria;
        }

        public void CargarCadetes(string path, Cadeteria cadeteria)
        {
            string linea, delimitador = ",";
            string[] cadena;
            Cadete cadete;
            if (File.Exists(path))
            {
                using (var archivo = new FileStream(path, FileMode.Open))
                {
                    using (var sr = new StreamReader(archivo))
                    {
                        sr.ReadLine();//linea de encabezado
                        linea = sr.ReadLine();
                        while (linea != null)
                        {

                            cadena = linea.Split(delimitador);
                            cadete = new Cadete(Convert.ToInt32(cadena[0]), cadena[1], cadena[0]);
                            cadeteria.CargarCadete(cadete);
                            linea = sr.ReadLine();
                        }


                    }
                }
            }

        }
    }

}