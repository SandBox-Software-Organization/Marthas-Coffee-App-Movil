using Marthas_Coffee_App_Movil.Tables;
using SQLite;
namespace Marthas_Coffee_App_Movil.Pages;

public partial class MainPage_Cuenta : ContentPage
{
	public MainPage_Cuenta()
	{
		InitializeComponent();
	}

    private void sesion_Clicked(object sender, EventArgs e)
    {
        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UsersDatabase.bd");
        var db = new SQLiteConnection(dbpath);
        var myquery = db.Table<RegistrarUsuario>().Where(u => u.Username.Equals(credenciales.Text) && u.Password.Equals(contra.Text)).FirstOrDefault();

        if(myquery != null)
        {
            App.Current.MainPage = new NavigationPage(new Inicio());
        }
        else
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Error", "Usuario o contraseña incorrecta. Revisar datos", "Yes", "Cancel");

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
        Navigation.PushModalAsync(new MainPage_Crear_Cuenta());
    }
}