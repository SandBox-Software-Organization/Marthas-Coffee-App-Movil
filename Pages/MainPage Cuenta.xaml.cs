using Marthas_Coffee_App_Movil.Tables;
using SQLite;
namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Cuenta : ContentPage
{
	public MainPage_Cuenta()
	{
		InitializeComponent();
	}

    [Obsolete]
    private void sesion_Clicked(object sender, EventArgs e)
    {
        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UsersDatabase.bd");
        var db = new SQLiteConnection(dbpath);
        var myquery = db.Table<RegistrarUsuario>().Where(u => u.Username.Equals(credenciales.Text) && u.Password.Equals(contra.Text)).FirstOrDefault();

        if(myquery != null)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
        else
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Datos incorrectos", "Usuario o contraseña incorrecta. Por favor verifique los datos ingresados", "Aceptar", "Cancelar");

                if (result)
                    await Navigation.PushAsync(new MainPage_Cuenta());
                else
                {
                    await Navigation.PushAsync(new MainPage_Cuenta());
                }
            }
            );
        }
    }

    private void Crear_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage_Crear_Cuenta());
    }
}