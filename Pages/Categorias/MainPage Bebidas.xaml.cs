using Marthas_Coffee_App_Movil.Pages.Categorias.Bebidas.Calientes;

namespace Marthas_Coffee_App_Movil.Pages.Categorias;

public partial class MainPage_Bebidas : ContentPage
{
	public MainPage_Bebidas()
	{
        InitializeComponent();
	}

    //Bebidas Frias//

    private void FriasBebida1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Frias.FriasBebida1 ());

    }

    private void FriasBebida2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Frias.FriasBebida2 ());

    }

    private void FriasBebida3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Frias.FriasBebida3 ());

    }

    //Bebidas Calientes//

    private void CalientesBebida1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Calientes.CalientesBebida1 ());

    }

    private void CalientesBebida2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Calientes.CalientesBebida2 ());

    }

    private void CalientesBebida3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Calientes.CalientesBebida3 ());

    }

    //Bebidas Naturales//

    private void NaturalesBebida1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Naturales.NaturalesBebida1 ());

    }

    private void NaturalesBebida2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bebidas.Naturales.NaturalesBebida1());

    }

    private async void NaturalesBebida3_Clicked(object sender, EventArgs e)

    {

       Navigation.PushAsync(new Pages.Categorias.Bebidas.Naturales.NaturalesBebida1 ());

    }

}