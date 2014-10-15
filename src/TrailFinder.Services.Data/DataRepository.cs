namespace TrailFinder.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Linq;

    using Dapper;

    public class DataRepository
    {
        #region Fields

        private static readonly string connectionString = ConfigurationManager.AppSettings["DBConnectionString"];

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

            Guid id = new Guid("B944070F-17FC-47A7-BA0D-1C662641757A");

            //super lame check to see if DB already contains seed data
            if (!existingIds.Any(x=> x.Equals(id)))
            {
                string sql = "INSERT INTO trail (id, name, latitude, longitude) VALUES "
                             + "('44c09d66-b9fc-455f-b1cd-37b12c28cdc0', '', '', ''),"
                             + "('f855e65e-081a-4da0-8699-c49277f55e59', '', '', ''),"
                             + "('45f446af-4b96-4e31-92bf-34d113cbfff8', '', '', ''),"
                             + "('99f54c8c-1885-46d5-b56e-97c87ef724ac', '', '', '')"
                             + "('d676d3c4-db61-40cd-93b1-f1938ac4c508', '', '', '')"
                             + "('93a5aa58-6cc9-4690-ba18-6704fa0602b2', '', '', '')"
                             + "('c175d0b9-c784-42b9-90cd-802c21ad2d36', '', '', '')"
                             + "('51ce040d-dee6-4df3-acd2-767e98eb5240', '', '', '')"
                             + "('0f6d8ddb-ccac-453a-bd6b-43ef1885c491', '', '', '')"
                             + "('e4ac84e9-5a3b-408d-8d45-89b8270350b5', '', '', '')"
                             + "('85b79e67-9433-4503-a863-0bdeb3fad51b', '', '', '')"
                             + "('52ac3b19-b328-4b1a-aa10-c0c40672b40d', '', '', '')"
                             + "('1795acfa-0b60-435a-9fc9-05bc30152dd5', '', '', '')"
                             + "('79a4293e-e08c-4d1c-be81-07b26795f0d4', '', '', '')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }


        }

        #endregion
    }
}
