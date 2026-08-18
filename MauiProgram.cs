using Microsoft.Extensions.Logging;

namespace ClassChat
{
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
                    fonts.AddFont("Font Awesome 7 Brands-Regular-400.otf", "FontIconRegularImg");
                    fonts.AddFont("Font Awesome 7 Free-Solid-900.otf", "FontIconSolid");
                    fonts.AddFont("Font Awesome 7 Free-Regular-400.otf", "FontIconRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
