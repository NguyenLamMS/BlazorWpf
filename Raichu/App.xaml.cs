using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using System.Windows;

namespace Raichu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static ServiceProvider serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddFluentUIComponents();
            serviceCollection.AddHttpClient();
            serviceCollection.AddScoped<AppState>();
            serviceProvider = serviceCollection.BuildServiceProvider();
            Resources.Add("services", serviceProvider);
            base.OnStartup(e);
        }
        public static T GetService<T>()
            where T : class
        {
            return serviceProvider.GetService(typeof(T)) as T;
        }
    }

}
