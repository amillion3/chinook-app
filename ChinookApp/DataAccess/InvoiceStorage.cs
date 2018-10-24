using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class InvoiceStorage
    {
        static List<InvoiceModel> _invoice = new List<InvoiceModel>()
        {
            new InvoiceModel
            {
                InvoiceId = 123,
                CustomerId = 1234,
                BillingAddress = "12345 Main St, Smith City, TN 37127",
                BillingCity = "Smith City",
                BillingState = "TN",
                BillingCountry = "USA",
                BillingPostalCode = "37127"
            }
        };

        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        public InvoiceModel GetInvoice(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = @"select *
                                    from Invoice
                                    where InvoiceId = @id";
                
                // below, sticks parameter of `id` into sql statement
                command.Parameters.AddWithValue("@id", id);

                // .ExecuteReader() gets/reads data from database 
                var result = command.ExecuteReader();

                if (result.Read())
                {
                    InvoiceModel invoiceResponse = new InvoiceModel
                    {
                        InvoiceId = (int)result["InvoiceId"],
                        CustomerId = (int)result["CustomerId"],
                        BillingAddress = result["BillingAddress"].ToString(),
                        BillingCity = result["BillingCity"].ToString(),
                        BillingState = result["BillingState"].ToString(),
                        BillingCountry = result["BillingCountry"].ToString(),
                        BillingPostalCode = result["BillingPostalCode"].ToString(),
                    };
                    return invoiceResponse;
                }
                return null;
            }
        }
    }
}
