using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class InsertInvoiceStorage
    {
        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        // Provide a new endpoint to INSERT a new invoice with 
        //  parameters for customerid and billing address

        //public InsertInvoiceModel InsertInvoice(int id, string address, string city, string state, string country, string zip)
        public bool InsertInvoice(int id, DateTime date, string address, string city, string state, string country, string zip, decimal total)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = @"insert into [dbo].Invoice ([CustomerId], [InvoiceDate], [BillingAddress], [BillingCity], [BillingState], [BillingCountry], [BillingPostalCode], [Total]) VALUES (@id, @date, @address, @city, @state, @country, @zip, @total)";

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@zip", zip);
                command.Parameters.AddWithValue("@total", total);

                int result = command.ExecuteNonQuery();
                return result == 1;
            }
        }

    }
}
