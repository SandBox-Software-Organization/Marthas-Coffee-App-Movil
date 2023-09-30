namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Inicio : ContentPage

{

	public MainPage_Inicio()

	{

		InitializeComponent();

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

        Navigation.PushAsync(new Postre());

    }

    private void ButtonBocadillos_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Bocadillos());

    }

}