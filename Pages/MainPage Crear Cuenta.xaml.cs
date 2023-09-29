using Marthas_Coffee_App_Movil.Tables;
using Network;
using SQLite;

namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Crear_Cuenta : ContentPage
{
	public MainPage_Crear_Cuenta()
	{
		InitializeComponent();
	}

    private async void RegresoCuenta_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushModalAsync(new MainPage_Cuenta());
    }

    private void Registro_Clicked(object sender, EventArgs e)
    {
        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UsersDatabase.bd");
        var db = new SQLiteConnection(dbpath);
        db.CreateTable<RegistrarUsuario>();

        var u = RegistrarUsuario(){
            Username = User.Text,

        }
    }
}