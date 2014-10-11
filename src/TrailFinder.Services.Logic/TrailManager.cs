namespace TrailFinder.Services.Logic
{
    using Interfaces;
    using ServiceModel.Requests;
    using ServiceModel.Responses;

    /// <summary>
    /// The trails manager.
    /// </summary>
    public class TrailManager : ITrailManager
    {
        #region Public Methods

        /// <inheritdoc />
        public GetTrailsResponse GetTrails(GetTrails request)
        {
            var response = new GetTrailsResponse();

            // var ticket = this.ticketRepository.RetrieveTicketsByEventId(request.EventId);

            return response;
        }

        #endregion
    }
}
