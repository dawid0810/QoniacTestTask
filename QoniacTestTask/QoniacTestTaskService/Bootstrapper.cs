using Autofac;
using BusinessCommon;
using BusinessServices;

namespace QoniacTestTaskService
{
    public class Bootstrapper
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BusinessServices.QoniacTestTaskService>().As<IQoniacTestTaskService>();

            builder.RegisterType<PriceParser>().As<IPriceParser>();

            return builder.Build();
        }
    }
}