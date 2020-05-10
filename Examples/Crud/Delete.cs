using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Examples.Crud
{
    public class Delete
    {
        private readonly int id;

        string conStr = @"Data Source=localhost; Initial Catalog=Test; Integrated Security=true; User ID=TestUser; Password=1s1";

        public Delete(int id)
        {
            this.id = id;
        }

        public string Remove()
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE User_Info WHERE Id = @Id";

                cmd.Parameters.AddWithValue("Id", id);

                cmd.ExecuteNonQuery();
            }

            return "Record is removed";
        }
    }
}
