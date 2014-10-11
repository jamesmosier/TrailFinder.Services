namespace TrailFinder.Services
{
    using Funq;
    using ServiceInterface;

    using ServiceStack;

    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("TrailFinder Services", typeof(TrailsService).Assembly)
        {

        }

        public override void Configure(Container container)
        {

        }
    }
}