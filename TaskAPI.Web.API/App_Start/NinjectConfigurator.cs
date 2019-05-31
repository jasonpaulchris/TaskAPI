using log4net.Config;
using Ninject;
using TaskAPI.Common;
using TaskAPI.Common.Logging;

namespace TaskAPI.Web.API.App_Start
{
    public class NinjectConfigurator
    {
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }

        private void AddBindings(IKernel container)
        {
            ConfigureLog4net(container);
            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
        }

        private void ConfigureLog4net(IKernel container)
        {
            XmlConfigurator.Configure();

            container.Bind<ILogManager>().ToConstant(logManager);
        }

        private void ConfigureNHibernate(IKernel container)
        {
            var sessionFactory = Fluently.Configure()
                .Database(
                        MsSqlConfiguration.MsSql2008.ConnectionString(
                            c => c.FromConnectionStringWithKey("TaskApiDb")))
                            .CurrentSessionContext("web")
                            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TaskMap>())
                            .BuildSessionFactory();

            container.Bind<ISessionFactory>().ToConstant(sessionFactory);
            containter.Bind<ISession>().ToMethod(CreateSession).InRequestScope();
        }
    }
}