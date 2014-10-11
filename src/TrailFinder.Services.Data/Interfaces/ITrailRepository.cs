namespace TrailFinder.Services.Data.Interfaces
{
    using System.Collections.Generic;
    using ServiceModel;

    /// <summary>
    /// The interface used to retrieve trail information.
    /// </summary>
    public interface ITrailRepository
    {
        #region Methods

        IEnumerable<TrailResponse> GetTrailHeads();

        #endregion
    }
}
