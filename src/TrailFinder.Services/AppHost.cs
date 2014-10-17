namespace TrailFinder.Services
{
    using Data;
    using Data.Interfaces;
    using Funq;
    using ServiceInterface;

    using ServiceStack;
    using ServiceStack.Api.Swagger;
    using Logic;
    using Logic.Interfaces;


    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("TrailFinder Services", typeof(TrailsService).Assembly)
        {
            //populate db automatically with data
            DataRepository.PopulateDb();
        }

        public override void Configure(Container container)
        {
            //these are so ServiceStack doesn't display Resources and ResourceRequest as Operations on the /metadata page
            typeof(Resources).AddAttributes(new RestrictAttribute { VisibilityTo = RequestAttributes.None });
            typeof(ResourceRequest).AddAttributes(new RestrictAttribute { VisibilityTo = RequestAttributes.None });

            container.RegisterAutoWiredAs<TrailRepository, ITrailRepository>();

            container.Register<ITrailManager>(c => new TrailManager(c.Resolve<ITrailRepository>()));

            //container.Register(c=> new TrailRepository(c.Resolve<IConfig>())).ReusedWithin(ReuseScope.Request);
            
            base.SetConfig(new HostConfig
            {
                GlobalResponseHeaders = {
                    { "Access-Control-Allow-Origin", "http://localhost" },
                    { "Access-Control-Allow-Methods", "GET, POST, PUT, OPTIONS" },
                    { "Access-Control-Allow-Headers", "Content-Type" },
                },
            });
        }
    }
}