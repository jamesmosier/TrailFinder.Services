namespace TrailFinder.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web.Configuration;

    using Dapper;

    public class DataRepository
    {
        #region Fields

        private static readonly string connectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        
        #endregion

        #region Public Methods

        public static void PopulateDb()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            List<Guid> existingIds = new List<Guid>();
            using (var connection = new SqlConnection(connectionString))
            {
                existingIds = connection.Query<Guid>("SELECT id FROM trail").ToList();
            }

            Guid id = new Guid("44c09d66-b9fc-455f-b1cd-37b12c28cdc0");

            //super lame check to see if DB already contains seed data
            if (!existingIds.Any(x => x.Equals(id)))
            {
                string sql = "INSERT INTO trail (id, name, latitude, longitude) VALUES "
                            + "('44c09d66-b9fc-455f-b1cd-37b12c28cdc0', 'Leonard Krieger CanalWay Center', '41.4335651', '81.6587305'),"
                            + "('f855e65e-081a-4da0-8699-c49277f55e59', 'Lock 39', '41.3938261', '81.6308123'),"
                            + "('45f446af-4b96-4e31-92bf-34d113cbfff8', 'Canal Visitor Center', '41.37242', '81.613224'),"
                            + "('99f54c8c-1885-46d5-b56e-97c87ef724ac', 'Fitzwater', '41.3494854', '81.6008175'),"
                            + "('d676d3c4-db61-40cd-93b1-f1938ac4c508', 'Frazee House', '41.352992', '81.591699'),"
                            + "('93a5aa58-6cc9-4690-ba18-6704fa0602b2', 'Big Bend Trailhead', '41.1262706', '81.5410812'),"
                            + "('c175d0b9-c784-42b9-90cd-802c21ad2d36', 'Memorial Parkway Trailhead', '41.1051406860352', '81.53164673'),"
                            + "('51ce040d-dee6-4df3-acd2-767e98eb5240', 'Mustill Store Trailhead', '41.1627693176269', '81.21634674'),"
                            + "('0f6d8ddb-ccac-453a-bd6b-43ef1885c491', 'Beech Street Trailhead', '41.0873985', '81.5183868'),"
                            + "('e4ac84e9-5a3b-408d-8d45-89b8270350b5', 'Summit Lake Trailhead', '41.0598183', '81.5429077'),"
                            + "('85b79e67-9433-4503-a863-0bdeb3fad51b', 'Wilbeth Road Trailhead', '41.0398753', '81.5405327'),"
                            + "('52ac3b19-b328-4b1a-aa10-c0c40672b40d', 'Manchester Road Trailhead', '41.0245371', '81.549274'),"
                            + "('1795acfa-0b60-435a-9fc9-05bc30152dd5', 'Barberton Trailhead', '41.0259285', '81.5899887'),"
                            + "('79a4293e-e08c-4d1c-be81-07b26795f0d4', 'Wolf Creek Trailhead', '41.0029922', '81.6074907'),"
                            + "('41cda765-3533-4b25-945a-f5e1def19710', 'Vanderhoof Road Trailhead', '40.9789124', '81.6065826'),"
                            + "('702c012b-cbfb-4307-9749-41099721a2d2', 'Franklin Trailhead', '40.9479922', '81.6188358'),"
                            + "('b1ac5dfb-f739-42c4-ba3e-338c1305bfdd', 'Clinton Trailhead', '40.928814', '81.629562')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }


        }

        #endregion
    }
}
