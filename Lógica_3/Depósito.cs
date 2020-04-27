using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica_3
{
    public delegate void Modificacion(Producto producto);
    public sealed class Depósito
    {
        public event Modificacion EventoModificacion;
        public static List<Producto> Productos { get; set; }
        private static Depósito instance = null;
        public static Depósito Instance
        {
            get
            {
                return instance == null ? instance = new Depósito() : instance;
            }
        }
        private Depósito()
        {

        }


        public void AgregarProducto(Monitor monitor)
        {
            Productos.Add(monitor);
            this.EventoModificacion(monitor);
        }
        public void AgregarProducto(Computadora compu)
        {
            Productos.Add(compu);
            this.EventoModificacion(compu);
        }
        public void EliminarProducto(string identificador)
        {
            var prod = Productos.First(x => x.Identificador == identificador);
            if (prod != null)
            {
                Productos.Remove(prod);
            }
        }

        

        
    }
}
