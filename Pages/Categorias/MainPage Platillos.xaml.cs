namespace Marthas_Coffee_App_Movil.Pages.Categorias;

public partial class MainPage_Platillos : ContentPage
{
	public MainPage_Platillos()
	{
        InitializeComponent();

	}

    //Platillos Ensaladas//

    private void PlatillosEnsaladas1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Ensaladas.PlatillosEnsaladas1());

    }

    private void PlatillosEnsaladas2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Ensaladas.PlatillosEnsaladas2());

    }

    private void PlatillosEnsaladas3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Ensaladas.PlatillosEnsaladas3());

    }

    //Platillos Entradas//

    private void PlatillosEntradas1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Entradas.PlatillosEntradas1());

    }

    private void PlatillosEntradas2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Entradas.PlatillosEntradas2());

    }

    private void PlatillosEntradas3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Entradas.PlatillosEntradas3());

    }

    //Platillos Platos Fuertes//

    private void PlatillosPlatosFuertes1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Platos_Fuertes.PlatillosPlatosFuertes1());

    }

    private void PlatillosPlatosFuertes2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Platos_Fuertes.PlatillosPlatosFuertes2());

    }

    private void PlatillosPlatosFuertes3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Platillos.Platos_Fuertes.PlatillosPlatosFuertes3());

    }

}