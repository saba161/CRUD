using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Examples.Crud
{
    public class Create
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly long phoneNumber;

        string conStr = @"Data Source=localhost; Initial Catalog=Test; Integrated Security=true; User ID=TestUser; Password=1s1";

        public Create(string firstName, string lastName, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public string Execute()
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT User_Info VALUES(@firstName, @lastName, @phoneNumber)";

                cmd.Parameters.AddWithValue("firstName", firstName);
                cmd.Parameters.AddWithValue("lastName", lastName);
                cmd.Parameters.AddWithValue("phoneNumber", phoneNumber);

                cmd.ExecuteNonQuery();
            }

            return "Recort is created";
        }
    }
}
