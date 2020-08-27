using Autofac;
using Contract;

namespace DataSource.IOC
{
    public class DataSourceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DisplayStringDataSource>()
                .As<IDataSource>();
        }
    }
}