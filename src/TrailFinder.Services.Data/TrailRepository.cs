namespace TrailFinder.Services.Data
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web.Configuration;

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

        private static readonly string connectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        #endregion

        #region Public Methods

        /// <inheritdoc />
        public IEnumerable<TrailResponse> GetTrailHeads()
        {
            IEnumerable<TrailResponse> trails;

            using (var connection = new SqlConnection(connectionString))
            {
                trails = connection.Query<TrailResponse>("SELECT * FROM trail").ToList();
            }

            return trails;
        }

        #endregion
    }
}
