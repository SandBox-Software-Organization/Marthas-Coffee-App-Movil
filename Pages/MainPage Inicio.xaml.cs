namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Inicio : ContentPage

{

    //Carrusel//
    public class CollectionItem
    {
        public string Imagen { get; set; }
    }

    public MainPage_Inicio()

	{

		InitializeComponent();

        var items = new List<CollectionItem>
        {
            new CollectionItem{Imagen ="calientesbebida1capuchino.png"},

            new CollectionItem{Imagen ="calientesbebida2moca.png"},

            new CollectionItem{Imagen = "calientesbebida3atol.png"}

        };
        carouselView.ItemsSource = items;

    }

    private void ButtonPlatillos_Clicked(object sender, EventArgs e)

    {

       Navigation.PushAsync(new Pages.Categorias.MainPage_Platillos ());

    }

    private void ButtonBebidas_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.MainPage_Bebidas ());

    }

    private void ButtonPostres_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.MainPage_Postres ());

    }

    private void ButtonBocadillos_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.MainPage_Bocadillos ());

    }

}