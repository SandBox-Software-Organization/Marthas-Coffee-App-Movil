using MvvmHelpers;
using System.Collections.ObjectModel;
using static Marthas_Coffee_App_Movil.Pages.Pedido;
using Microsoft.Maui.Controls;


namespace Marthas_Coffee_App_Movil
{
    public class MainViewModel : BaseViewModel
    {
       private ObservableCollection<CPedido> _listproducts;
        public ObservableCollection<CPedido> ListProducts
        {
            get { return _listproducts; }
            set { SetProperty(ref _listproducts, value); }
        }
       //public List<DetailsView> ListProducts { get; set; } 

        public MainViewModel()
        {
           ListProducts = new ObservableCollection<CPedido>
            {
                new CPedido { Platillos = "Ensalada", Bebidas = "Agua", Postres = "Helado", Bocadillos = "Galletas" },
                new CPedido { Platillos = "Pizza", Bebidas = "Refresco", Postres = "Pastel", Bocadillos = "Nachos" }
            };

            // Agrega más productos aquí 
        }
    }
}
