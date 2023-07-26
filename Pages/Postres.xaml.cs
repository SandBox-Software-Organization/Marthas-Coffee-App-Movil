using Marthas_Coffee_App_Movil.Pages.Categorias.Postres;

namespace Marthas_Coffee_App_Movil.Pages;

public partial class Postres : ContentPage

{

    public Postres()

    {

        InitializeComponent();

    }

    private void ImageButtonPastel_Clicked(object sender, EventArgs e)

    {



    }

    private void ImageButtonMochi_Clicked(object sender, EventArgs e)

    {

        Navigation.PushModalAsync(new Mochi());

    }
}