namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Usuario : ContentPage
{
	public MainPage_Usuario()
	{
		InitializeComponent();
	}

    void CerrarSesion_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new MainPage_Cuenta());

    }

}