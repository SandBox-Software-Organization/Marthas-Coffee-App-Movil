namespace Marthas_Coffee_App_Movil.Pages.Categorias.Postres;

public partial class Mochi : ContentPage
{
	public Mochi()
	{
		InitializeComponent();
	}

	private void RegeresoInicio_Clicked(object sender, EventArgs e)
	{

		Navigation.PushModalAsync(new Postre());
	}
}