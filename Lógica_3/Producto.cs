using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica_3
{
    public class Producto
    {
        private string Modelo { get; set; }
        private string Marca { get; set; }
        private int NumeroDeSerie { get; set; }
        public string Identificador
        {
            get
            {
                return Modelo + Marca + NumeroDeSerie.ToString();
            }
        }

        public virtual string ObtenerDescripcion()
        {
            return this.Modelo + this.Marca;
        }


    }
}
