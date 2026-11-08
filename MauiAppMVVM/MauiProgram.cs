using MauiAppMVVM.Services;
using MauiAppMVVM.ViewModels;
using MauiAppMVVM.Views;
using Microsoft.Extensions.Logging;


namespace MauiAppMVVM
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.AddPages().AddVmPages().AddServices();
            return builder.Build();
        }
        public static MauiAppBuilder AddPages(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<RegisterPage>();
            builder.Services.AddTransient<UserList>();
            builder.Services.AddTransient<UserDataPage>();
            return builder;
        }
        public static MauiAppBuilder AddVmPages(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginPageVm>();
            builder.Services.AddTransient<RegisterPageVM>();
            builder.Services.AddTransient<UserListVM>();
            builder.Services.AddTransient<UserDataPageVM>();
            return builder;
        }
        public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDataService, DBdemo>();
            return builder;
        }
    }
}
