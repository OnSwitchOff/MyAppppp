using MyApp.Application.Services.Activation;
using MyApp.Configurations;
using MyApp.Prerequisite.Win32.WindowIconLoaders;
using Microsoft.UI.Xaml;
using CommunityToolkit.Mvvm.DependencyInjection;


namespace MyApp
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App : Microsoft.UI.Xaml.Application
    {
        public App()
        {
            InitializeComponent();
        }

        // Windows must be static, because of WinAPI resources allocation.
        public static Window MainWindow { get; private set; } = new() { Title = "Axis UNO" };

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);

            Ioc.Default.ConfigureServices(Startup.ConfigureServices());

            var activationService = Ioc.Default.GetRequiredService<IActivationService>();
            await activationService.ActivateAsync(args);

            InitializeWindow();
        }

        private static void InitializeWindow()
        {
            WindowIconLoader.LoadIcon(MainWindow, @"Assets\Icons\WindowIcon.ico");
        }
    }
}
