namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Pedidos : ContentPage
{

    public class CPedido
    {
        public string Platillos { get; set; }
        public string Bebidas { get; set; }
        public string Bocadillos { get; set; }
        public string Postres { get; set; }

    }

    public MainPage_Pedidos()
	{
		InitializeComponent();

        BindingContext = new MainViewModel();
    }
}