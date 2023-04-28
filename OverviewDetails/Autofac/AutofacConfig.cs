using Autofac;
using OverviewDetails.ViewModels;

namespace OverviewDetails.Autofac
{
    public class AutofacConfig
    {
        public static IContainer GetContainer { get; set; }

        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<InteractionWithFilesViewModel>();
            //builder.RegisterType<InteractionOnCanvasViewModel>();
            //builder.RegisterType<WorkWithJson>();
            //builder.RegisterType<WorkWithXml>();
            builder.Register(x => new MainViewModel
            (
                x.Resolve<MenuViewModel>(),
                x.Resolve<DetailViewModel>(),
                x.Resolve<WindowForDetailViewModel>()
            ));

            GetContainer = builder.Build();
        }
    }
}