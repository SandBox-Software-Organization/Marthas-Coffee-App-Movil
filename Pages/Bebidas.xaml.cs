namespace Marthas_Coffee_App_Movil.Pages;

public partial class Bebidas : ContentPage
{
	public Bebidas()
	{
		InitializeComponent();
	}

    private void RegresoInicio_Clicked(object sender, EventArgs e)
    {

        Navigation.PushModalAsync(new MainPage());
    }
}