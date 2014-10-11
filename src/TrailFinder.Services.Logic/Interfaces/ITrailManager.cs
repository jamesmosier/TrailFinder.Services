namespace TrailFinder.Services.Logic.Interfaces
{
    using ServiceModel.Requests;
    using ServiceModel.Responses;

    /// <summary>
    /// The interface used to retrieve ticket information.
    /// </summary>
    public interface ITrailManager
    {
        #region Methods

        GetTrailsResponse GetTrails(GetTrails request);

        #endregion
    }
}
