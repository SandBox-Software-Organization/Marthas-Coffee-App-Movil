namespace Marthas_Coffee_App_Movil.Pages;

public partial class Platillos : ContentPage
{
	public Platillos()
	{
		InitializeComponent();
	}

    private void RegresoInicio_Clicked(object sender, EventArgs e)
    {

        Navigation.PushModalAsync(new MainPage());
    }

    public static implicit operator Button(Platillos v)
    {
        throw new NotImplementedException();
    }
}