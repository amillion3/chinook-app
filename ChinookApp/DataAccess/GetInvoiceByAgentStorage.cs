using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ChinookApp.DataAccess
{
    public class GetInvoiceByAgentStorage
    {
        private readonly string ConnectionString;

        public GetInvoiceByAgentStorage(IConfiguration config)
        {
            ConnectionString = config.GetSection("ConnectionString").Value;
        }
        // Provide an endpoint that shows the invoices associated with each sales agent. 
        // The result should include the Sales Agent's full name.
        public GetInvoiceByAgentModel GetInvoiceByAgent(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var result = db.QueryFirst<GetInvoiceByAgentModel>(
                    @"select *, (Employee.FirstName + ' ' + Employee.LastName) as CustomerName
                    from Employee
                        join Customer on Employee.EmployeeId = Customer.SupportRepId
                            join Invoice on Customer.SupportRepId = Invoice.CustomerId
                    where Employee.EmployeeId = @id", new { id }
                );
            return result;
            }
        }
    }
}
