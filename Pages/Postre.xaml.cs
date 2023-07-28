using Marthas_Coffee_App_Movil.Pages.Categorias.Postres;

namespace Marthas_Coffee_App_Movil.Pages;

public partial class Postre : ContentPage

{

    public Postre()

    {

        InitializeComponent();

    }

    private void RegresoInicio_Clicked(object sender, EventArgs e)
    {

        Navigation.PushModalAsync(new MainPage());
    }

    private void ImageButtonPastel_Clicked(object sender, EventArgs e)

    {



    }

    private void ImageButtonMochi_Clicked(object sender, EventArgs e)

    {

        Navigation.PushModalAsync(new Mochi());

    }
}