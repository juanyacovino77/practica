using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica_3
{
    public class Monitor : Producto
    {
        public int AñoDeFabricacion { get; set; }
        public bool NuevoUsado
        {
            get
            {
                return AñoDeFabricacion == DateTime.Today.Year ? true : false;  
            }

        }
        public int? Pulgadas { get; set; }

        public override string ObtenerDescripcion()
        {
            return base.ObtenerDescripcion() + this.Pulgadas;
        }

    }
}
