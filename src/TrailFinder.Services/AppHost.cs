namespace TrailFinder.Services
{
    using Data;
    using Data.Interfaces;
    using Funq;
    using ServiceInterface;

    using ServiceStack;
    using ServiceStack.Api.Swagger;

    using Core;
    using Data;
    using Data.Interfaces;
    using Logic;
    using Logic.Interfaces;


    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("TrailFinder Services", typeof(TrailsService).Assembly)
        {

        }

        public override void Configure(Container container)
        {
            container.RegisterAutoWiredAs<TrailRepository, ITrailRepository>();

            container.Register<ITrailManager>(c => new TrailManager(c.Resolve<ITrailRepository>()));

            //container.Register(c=> new TrailRepository(c.Resolve<IConfig>())).ReusedWithin(ReuseScope.Request);

            Plugins.Add(new SwaggerFeature());
        }
    }
}