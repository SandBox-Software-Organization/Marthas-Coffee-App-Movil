using Marthas_Coffee_App_Movil.Tables;

using SQLite;

namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Crear_Cuenta : ContentPage
{
	public MainPage_Crear_Cuenta()
	{
		InitializeComponent();
	}

    [Obsolete]
    private void Registro_Clicked(object sender, EventArgs e)
    {
        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UsersDatabase.bd");
        var db = new SQLiteConnection(dbpath);
        db.CreateTable<RegistrarUsuario>();

        var u = new RegistrarUsuario(){
            Username = User.Text,
                Password = contraseña.Text,
                Email = email.Text,
                NPhone = telefono.Text

        };
        db.Insert(u);
        Device.BeginInvokeOnMainThread(async () =>
        {

            var result = await this.DisplayAlert("¡Bienvenid@!", "se ha registrado correctamente", "Aceptar", "Cancelar");

            if (result)
                await Navigation.PushAsync(new MainPage_Cuenta());
        });
    }
}