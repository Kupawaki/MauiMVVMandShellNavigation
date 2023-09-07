using MauiMVVMandShellNavigation.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiMVVMandShellNavigation
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
                });

            //Creates one semi-permanent copy
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            //Creates several disposable copies
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();

            #if DEBUG
		    builder.Logging.AddDebug();
            #endif

            return builder.Build();
        }
    }
}