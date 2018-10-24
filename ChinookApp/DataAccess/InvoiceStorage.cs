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
        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        public InvoiceModel GetInvoiceByAgent(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var command = db.CreateCommand();
                // do i need the customer in here???
                command.CommandText =
                    @"select
                    EmployeeFullName = Employee.FirstName + ' ' + Employee.LastName,
	                CustomerFullName = Customer.FirstName + ' ' + Customer.LastName,
	                Invoice.InvoiceId
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
