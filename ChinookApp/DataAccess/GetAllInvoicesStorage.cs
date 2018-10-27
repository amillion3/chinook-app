using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;
using System.Collections;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ChinookApp.DataAccess
{
    public class GetAllInvoicesStorage
    {
        private readonly string ConnectionString;

        public GetAllInvoicesStorage(IConfiguration config)
        {
            ConnectionString = config.GetSection("ConnectionString").Value;
        }

        // Provide an endpoint that shows the Invoice Total, Customer name, 
        //  Country and Sale Agent name for all invoices.
        public IEnumerable<GetAllInvoicesModel> GetAllInvoices()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();

                var result = db.Query<GetAllInvoicesModel>(
                    @"select *, (Customer.FirstName + ' ' + Customer.LastName) as CustomerName, (Employee.FirstName + ' ' + Employee.LastName) as AgentName
                    from Employee
	                    join Customer on Employee.EmployeeId = Customer.SupportRepId
		                    join Invoice on Customer.CustomerId = Invoice.CustomerId"
                );
                return result.ToList();
            }
        }
    }
}
