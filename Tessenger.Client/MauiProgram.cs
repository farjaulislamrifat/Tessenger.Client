using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using DevExpress.Maui;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using Tessenger.Client.Custom.Algorithms;

namespace Tessenger.Client
{
    public static class MauiProgram
    {

        /// <summary>
        ///  The MauiApp instance
        /// </summary>
        public static MauiApp Instance { get; private set; }

        public static MauiApp CreateMauiApp()
        {
            // Create a new MauiApp
            var builder = MauiApp.CreateBuilder();


            // Add services to the container.
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitCamera()
                .UseMauiCommunityToolkitMediaElement()
                .UseDevExpressCollectionView()
                .UseMauiCommunityToolkitCore()
                .UseDevExpressControls()
                .UseDevExpress()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            // Add BlazorWebView
            builder.Services.AddMauiBlazorWebView();



            // Transients
            builder.Services.AddTransient<IAlgorithms, Algorithms>();


            // Singletons


            // Scopeds

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            var app = builder.Build();
            Instance = app;
            return Instance;
        }
    }
}
