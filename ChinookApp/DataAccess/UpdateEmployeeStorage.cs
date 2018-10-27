using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class UpdateEmployeeStorage
    {
        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        // Provide a new endpoint to UPDATE an Employee's name with a 
        //  parameter for Employee Id and new name

        public bool UpdateEmployee (int id, string first, string last)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var command = db.CreateCommand();

                command.CommandText = @"update [dbo].Employee
                                        set FirstName = @first, LastName = @last
                                        where EmployeeId = @id";

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@first", first);
                command.Parameters.AddWithValue("@last", last);

                int result = command.ExecuteNonQuery();
                return result == 1;

            }
        }
    }
}
