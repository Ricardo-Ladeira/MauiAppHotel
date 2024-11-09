using Microsoft.Extensions.Logging;

namespace MauiAppHotel;

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
				fonts.AddFont("PlaywriteGBS-Italic-VariableFont_wght.ttf", "PlaywriteGBS-Italic");
				fonts.AddFont("PlaywriteGBS-VariableFont_wght.ttf", "PlaywriteGBS");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
