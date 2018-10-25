using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class GetInvoiceByAgentStorage
    {
        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        // Provide an endpoint that shows the invoices associated with each sales agent. 
        // The result should include the Sales Agent's full name.
        public GetInvoiceByAgentModel GetInvoiceByAgent(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText =
                    @"select *
                    from Employee
                        join Customer on Employee.EmployeeId = Customer.SupportRepId
                            join Invoice on Customer.SupportRepId = Invoice.CustomerId
                    where Employee.EmployeeId = @id";
                
                // below, sticks parameter of `id` into sql statement
                command.Parameters.AddWithValue("@id", id);

                // .ExecuteReader() gets/reads data from database 
                var result = command.ExecuteReader();

                if (result.Read())
                {
                    GetInvoiceByAgentModel invoiceResponse = new GetInvoiceByAgentModel
                    {
                        CustomerName = result["FirstName"].ToString() + " " + result["LastName"].ToString(),
                        InvoiceId = (int)result["InvoiceId"],
                        CustomerId = (int)result["CustomerId"],
                        BillingAddress = result["BillingAddress"].ToString(),
                        BillingCity = result["BillingCity"].ToString(),
                        BillingState = result["BillingState"].ToString(),
                        BillingCountry = result["BillingCountry"].ToString(),
                        BillingPostalCode = result["BillingPostalCode"].ToString(),
                        Total = (decimal)result["Total"]
                    };
                    return invoiceResponse;
                }
                return null;
            }
        }
    }
}
