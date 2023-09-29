namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Crear_Cuenta : ContentPage
{
	public MainPage_Crear_Cuenta()
	{
		InitializeComponent();
	}

    private async void RegresoCuenta_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushModalAsync(new MainPage_Cuenta());
    }
}