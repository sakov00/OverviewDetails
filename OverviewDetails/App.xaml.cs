using System.Windows;

namespace OverviewDetails
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Autofac.AutofacConfig.ConfigureContainer();
        }
    }
}
