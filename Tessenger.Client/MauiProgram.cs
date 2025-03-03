using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using DevExpress.Maui;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using Tessenger.Client.Custom.Algorithms;
using Tessenger.Client.Data_Db_Contexts;
using Tessenger.Client.Services.Api_Services;

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
            builder.Services.AddScoped<IApi_Services, Api_Services>();
            builder.Services.AddScoped<Data_Db_Contexts>();



            // Add Configuration File
            using var stream = FileSystem.OpenAppPackageFileAsync("appsetting.json");
            var config = new ConfigurationBuilder().AddJsonStream(stream.Result).Build();
            builder.Configuration.AddConfiguration(config);


            // Create Database
            var db = new Data_Db_Contexts.Data_Db_Contexts();
            db.Database.EnsureCreated();
            db.Dispose();


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
