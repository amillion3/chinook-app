using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;
using System.Collections;

namespace ChinookApp.DataAccess
{
    public class GetAllInvoicesStorage
    {
        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        // Provide an endpoint that shows the Invoice Total, Customer name, 
        //  Country and Sale Agent name for all invoices.
        public IEnumerable<GetAllInvoicesModel> GetAllInvoices()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = @"select *, Customer.FirstName as CustomerFirstName, Customer.LastName as CustomerLastName, Employee.FirstName as EmployeeFirstName, Employee.LastName as EmployeeLastName
                    from Employee
	                    join Customer on Employee.EmployeeId = Customer.SupportRepId
		                    join Invoice on Customer.CustomerId = Invoice.CustomerId";

                var result = command.ExecuteReader();

                List<GetAllInvoicesModel> InvoiceResponse = new List<GetAllInvoicesModel>();

                while (result.Read())
                {
                    GetAllInvoicesModel invoicesResponse = new GetAllInvoicesModel
                    {
                        InvoiceTotal = (decimal)result["Total"],
                        CustomerName = result["CustomerFirstName"].ToString() + " " + result["CustomerLastName"].ToString(),
                        Country = result["BillingCountry"].ToString(),
                        AgentName = result["EmployeeFirstName"].ToString() + " " + result["EmployeeLastName"].ToString()
                    };
                    InvoiceResponse.Add(invoicesResponse);
                }
            return InvoiceResponse;
            }
        }
    }
}
