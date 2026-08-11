using System.Data.SqlClient;

namespace CSharpWebApi.Analysis
{
    public sealed class SastFixture
    {
        private const string AdminPassword = "admin123";

        public void GetUser(SqlConnection conn, string username)
        {
            var query = "SELECT * FROM Users WHERE Username = '" + username + "'";
            var cmd = new SqlCommand(query, conn);
            cmd.ExecuteReader();
        }
    }
}
