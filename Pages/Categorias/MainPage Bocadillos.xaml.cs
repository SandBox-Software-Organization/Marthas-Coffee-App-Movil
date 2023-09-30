namespace Marthas_Coffee_App_Movil.Pages.Categorias;

public partial class MainPage_Bocadillos : ContentPage
{
	public MainPage_Bocadillos()
	{
        InitializeComponent();
	}

    //Bocadillos Acidos//

    private void AcidosBocadillos1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Acidos.BocadillosAcido1());

    }

    private void AcidosBocadillos2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Acidos.BocadillosAcido2 ());

    }

    private void AcidosBocadillos3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Acidos.BocadillosAcido3());

    }

    //Bocadillos Bulces//

    private void BocadillosDulces1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Dulces.BocadillosDulces1());

    }

    private void BocadillosDulces2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Dulces.BocadillosDulces2());

    }

    private void BocadillosDulces3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Dulces.BocadillosDulces3());

    }

    //Bocadillos Salados//

    private void BocadillosSalados1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Salados.BocadillosSalados1());

    }

    private void BocadillosSalados2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Salados.BocadillosSalados2());

    }

    private void BocadillosSalados3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Bocadillos.Salados.BocadillosSalados3());

    }

}