namespace TrailFinder.Services.ServiceInterface
{
    using Logic.Interfaces;
    using ServiceModel.Requests;
    using ServiceModel.Responses;
    using ServiceStack;

    /// <summary>
    /// The tickets service.
    /// </summary>
    public class TrailsService : Service
    {
        #region Fields

        private readonly ITrailManager trailManager;

        #endregion

        #region Constructors

        public TrailsService(ITrailManager trailManager)
        {
            this.trailManager = trailManager;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc />
        public GetTrailsResponse Get(GetTrails request)
        {
            return trailManager.GetTrails(request);
        }

        #endregion
    }
}
