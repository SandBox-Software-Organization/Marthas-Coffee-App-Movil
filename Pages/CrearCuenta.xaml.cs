namespace Marthas_Coffee_App_Movil.Pages.Categorias.Cuenta;

public partial class CrearCuenta : ContentPage
{
	public CrearCuenta()
	{
		InitializeComponent();
	}

    private void RegresoCuenta_Clicked(object sender, EventArgs e)
    {

        Navigation.PushModalAsync(new MainPage());
    }
}