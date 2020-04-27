using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lógica_3
{
    public enum CantidadRam { dos, cuatro, ocho, diesciseis }

    public sealed class Computadora : Producto
    {
        public string DescripcionMicro { get; set; }
        public CantidadRam ram { get; set; }
        public string Fabricante { get; set; }

        public override string ObtenerDescripcion()
        {
            return base.ObtenerDescripcion() + this.DescripcionMicro + this.MemoriaRam.ToString();
        }


    }
}
