namespace TrailFinder.Services.Logic
{
    using Data.Interfaces;
    using Interfaces;
    using ServiceModel.Requests;
    using ServiceModel.Responses;

    /// <summary>
    /// The trails manager.
    /// </summary>
    public class TrailManager : ITrailManager
    {
        #region Fields  

        private readonly ITrailRepository trailRepository;

        #endregion

                #region Constructors

        public TrailManager(ITrailRepository iTrailRepository)
        {
            trailRepository = iTrailRepository;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc />
        public GetTrailsResponse GetTrails(GetTrails request)
        {
            var response = new GetTrailsResponse();

            var trails = this.trailRepository.GetTrailHeads();

            return response;
        }

        #endregion
    }
}
