namespace Marthas_Coffee_App_Movil.Pages.Categorias;

public partial class MainPage_Postres : ContentPage
{
	public MainPage_Postres()
	{
		InitializeComponent();
	}

    private void ImageButtonMochi_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Pages.Categorias.Postres.Mochi());

    }
}