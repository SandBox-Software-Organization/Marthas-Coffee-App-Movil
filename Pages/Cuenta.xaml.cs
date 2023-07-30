using Marthas_Coffee_App_Movil.Pages.Categorias.Cuenta;

namespace Marthas_Coffee_App_Movil.Pages;

public partial class Cuenta : ContentPage
{
	public Cuenta()
	{
		InitializeComponent();
	}

	private void sesion_Clicked(object sender, EventArgs e)
	{

	}

	private void Crear_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new CrearCuenta());
	}
}