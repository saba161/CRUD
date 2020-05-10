using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Examples.Crud
{
    public class Read
    {
        private readonly int id;

        string conStr = @"Data Source=localhost; Initial Catalog=Test; Integrated Security=true; User ID=TestUser; Password=1s1";

        public Read(int id)
        {
            this.id = id;
        }

        public ArrayList ReadRecord()
        {
            ArrayList allRecord = new ArrayList();

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "Select * From User_Info WHERE Id = @Id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        allRecord.Add(reader.GetInt32(0));
                        allRecord.Add(reader.GetString(1));
                        allRecord.Add(reader.GetString(2));
                        allRecord.Add(reader.GetInt64(3));
                    }
                }
            }
            return allRecord;
        }
    }
}
