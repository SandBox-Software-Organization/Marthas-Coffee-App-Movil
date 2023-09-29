namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Cuenta : ContentPage
{
	public MainPage_Cuenta()
	{
		InitializeComponent();
	}

    private void sesion_Clicked(object sender, EventArgs e)
    {

    }

    private void Crear_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MainPage_Crear_Cuenta());
    }
}