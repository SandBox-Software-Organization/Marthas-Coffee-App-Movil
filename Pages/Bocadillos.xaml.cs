namespace Marthas_Coffee_App_Movil.Pages;

public partial class Bocadillos : ContentPage
{
	public Bocadillos()
	{
		InitializeComponent();
	}

    private void RegresoInicio_Clicked(object sender, EventArgs e)
    {

        Navigation.PushModalAsync(new MainPage());
    }
}