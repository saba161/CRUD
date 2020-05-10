using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;

namespace Examples.Crud
{
    public class Update
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly long phoneNumber;
        private readonly int id;

        string conStr = @"Data Source=localhost; Initial Catalog=Test; Integrated Security=true; User ID=TestUser; Password=1s1";

        public Update(int id, string firstName, string lastName, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.id = id;
        }

        public string UpdateRecord()
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE User_Info SET FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber WHERE Id = @id";

                cmd.Parameters.AddWithValue("firstName", firstName);
                cmd.Parameters.AddWithValue("lastName", lastName);
                cmd.Parameters.AddWithValue("phoneNUmber", phoneNumber);
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();
            }

            return "Record is updated";
        }
    }
}
