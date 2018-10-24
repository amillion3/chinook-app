using System;
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

        private const string ConnectionString = "Server=(local);Database=hihihihi;Trusted_Connection=True;";

        public bool addNewInvoice(InvoiceModel invoice)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return true;
            }
        }
    }
}
