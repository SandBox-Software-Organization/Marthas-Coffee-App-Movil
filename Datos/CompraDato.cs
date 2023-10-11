using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marthas_Coffee_App_Movil.Datos
{
    public class CompraDato
    {
        public string NumeroCompra { get; set; }
        public decimal Total { get; set; }
        public DireccionDato RefDireccion { get; set; }
        public virtual TarjetaDato RefTarjeta { get; set; }
        public string FechaRegistro { get; set; }
    }
}
