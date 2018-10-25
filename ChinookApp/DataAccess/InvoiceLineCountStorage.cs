using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class InvoiceLineCountStorage
    {
        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        // Looking at the InvoiceLine table, provide an endpoint that COUNTs the number 
        //  of line items for an Invoice with a parameterized Id from user input.
        // HINT, this could use `ExecuteScalar`

    public InvoiceLineCountModel InvoiceLineCount(int id)
    {
        using (var db = new SqlConnection(ConnectionString))
        {
            db.Open();
            var command = db.CreateCommand();
            command.CommandText = @"";

            var result = command.ExecuteScalar();
        }
    }
}
