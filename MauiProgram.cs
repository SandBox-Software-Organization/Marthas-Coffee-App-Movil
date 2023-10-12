using Marthas_Coffee_App_Movil.DataAccess;
using Microsoft.Extensions.Logging;

namespace Marthas_Coffee_App_Movil;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

       // Agregar el contexto a la base de datos y la pagina
        builder.Services.AddDbContext<MarthasCoffeDbContext>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
