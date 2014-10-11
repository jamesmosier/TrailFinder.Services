namespace TrailFinder.Services.Data
{
    using System.Collections.Generic;
    using Interfaces;
    using ServiceModel;

    using Dapper;

    /// <summary>
    /// The repository used to access trail information from the data source.
    /// </summary>
    public class TrailRepository : ITrailRepository
    {
        #region Public Methods

        /// <inheritdoc />
        public IEnumerable<TrailResponse> GetTrailHeads()
        {
            return null;
        }

        #endregion
    }
}
