using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marthas_Coffee_App_Movil.Datos
{
    public partial class PedidoDato : ObservableObject
    {
        [ObservableProperty]
        public int idCarrito;
        [ObservableProperty]
        public ProductoDato producto;
        [ObservableProperty]
        public int cantidad;
        [ObservableProperty]
        public decimal total;
    }
}
