using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ChinookApp.DataAccess
{
    public class InsertInvoiceStorage
    {
        private readonly string ConnectionString;

        public InsertInvoiceStorage(IConfiguration config)
        {
            ConnectionString = config.GetSection("ConnectionString").Value;
        }
        // Provide a new endpoint to INSERT a new invoice with 
        //  parameters for customerid and billing address

        public bool InsertInvoice(int id, InsertInvoiceModel InsertInvoiceModel333)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var result = db.Execute(
                    @"insert into [dbo].Invoice ([CustomerId], [InvoiceDate], [BillingAddress], [BillingCity], [BillingState], [BillingCountry], [BillingPostalCode], [Total]) 
                    VALUES (@id, @date, @address, @city, @state, @country, @zip, @total)", new {id, InsertInvoiceModel333}
                );
                
                return result == 1;
            }
        }

    }
}
