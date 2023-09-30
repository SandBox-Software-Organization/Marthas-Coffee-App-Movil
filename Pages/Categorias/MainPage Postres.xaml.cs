namespace Marthas_Coffee_App_Movil.Pages.Categorias;

public partial class MainPage_Postres : ContentPage
{
	public MainPage_Postres()
	{
        InitializeComponent();
	}

    private void ImageButtonMochi_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new ());

    }

    //Postres Calientes//

    private void PostresCalientes1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Calientes.PostresCalientes1());

    }

    private void PostresCalientes2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Calientes.PostresCalientes2());

    }

    private void PostresCalientes3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Calientes.PostresCalientes3());

    }

    //Postres Dulces//

    private void PostresDulces1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Dulces.PostresDulces1());

    }

    private void PostresDulces2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Dulces.PostresDulces2());

    }

    private void PostresDulces3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Dulces.PostresDulces3());

    }

    //Postres Frios//

    private void PostresFrios1_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Frios.PostresFrios1());

    }

    private void PostresFrios2_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Frios.PostresFrios2());

    }

    private void PostresFrios3_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Frios.PostresFrios3());

    }

}