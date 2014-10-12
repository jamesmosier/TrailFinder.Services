namespace TrailFinder.Services.Data
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using Interfaces;
    using ServiceModel;

    using System.Configuration;

    using Dapper;

    /// <summary>
    /// The repository used to access trail information from the data source.
    /// </summary>
    public class TrailRepository : ITrailRepository
    {

        #region Fields

        private static readonly string connectionString = ConfigurationManager.AppSettings["DBConnectionString"];

        #endregion

        #region Public Methods

        /// <inheritdoc />
        public IEnumerable<TrailResponse> GetTrailHeads()
        {
            IEnumerable<TrailResponse> trails;

            using (var connection = new SqlConnection(connectionString))
            {
                //id AS Id, name AS Name, description AS Description, latitude AS Latitude, longitude AS Longitude
                trails = connection.Query<TrailResponse>("SELECT * FROM trail").ToList();
            }

            var trap = 12;

            return trails;
        }

        #endregion
    }
}
