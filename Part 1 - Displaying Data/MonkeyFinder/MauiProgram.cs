using Microsoft.Extensions.Logging;
using MonkeyFinder.View;
using MonkeyFinder.Services;


namespace MonkeyFinder;

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
                });


           
            builder.Logging.AddDebug();


        
    builder.Services.AddSingleton<MonkeyService>();
        builder.Services.AddSingleton<MonkeysViewModel>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}
