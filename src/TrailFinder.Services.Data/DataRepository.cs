namespace TrailFinder.Services.Data
{
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class DataRepository
    {
        #region Fields

        private static readonly string connectionString = ConfigurationManager.AppSettings["DBConnectionString"];

        #endregion

        #region Public Methods

        public static void PopulateDb()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string sql = "INSERT INTO trail (id, name, latitude, longitude) VALUES ('AF34070F-17FC-47A7-BA0D-1C662641757A', 'James Place', '99.9999999', '-88.888888')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.Add("@name", SqlDbType.VarChar);
            //cmd.Parameters["@name"].Value = test;
            cmd.ExecuteNonQuery();
        }

        #endregion
    }
}
