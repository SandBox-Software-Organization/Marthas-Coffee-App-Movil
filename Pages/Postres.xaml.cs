namespace Marthas_Coffee_App_Movil.Pages;

public partial class Postres : ContentPage
{
	public Postres()
	{
		InitializeComponent();
	}
	private void ImageButtonMochi_Clicked (object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new mochi());
	}
}