namespace Marthas_Coffee_App_Movil.Pages;

public partial class Inicio : ContentPage

{ 

    public Inicio()

    {

        InitializeComponent();

    }

  

    private void ButtonPlatillos_Clicked(object sender, EventArgs e)

    {

        Navigation.PushModalAsync(new Platillos());

    }

    private void ButtonBebidas_Clicked(object sender, EventArgs e)

    {



    }

    private void ButtonPostres_Clicked(object sender, EventArgs e)

    {



    }

    private void ButtonBocadillos_Clicked(object sender, EventArgs e)

    {



    }

}