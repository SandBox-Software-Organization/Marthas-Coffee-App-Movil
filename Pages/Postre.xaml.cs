using Marthas_Coffee_App_Movil.Pages.Categorias.Postres;

namespace Marthas_Coffee_App_Movil.Pages;

public partial class Postre : ContentPage

{

    public Postre()

    {

        InitializeComponent();

    }

    private void ImageButtonMochi_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Mochi());

    }
}