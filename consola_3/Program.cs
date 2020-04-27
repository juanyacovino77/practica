using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lógica_3;

namespace consola_3
{

    public static class Program
    {
        static void Main(string[] args)
        {
            var deposito = Depósito.Instance;
            deposito.EventoModificacion += CapturarModificacion;

            //pedir datos de algun producto





        }

        private static void CapturarModificacion(Producto producto)
        {
            Console.WriteLine(producto.ObtenerDescripcion());
        }

        public static bool ValidarRAM(this Computadora compu, string ramsss)
        {
            return true;
        }

    }
}
