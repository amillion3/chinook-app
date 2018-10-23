using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class InvoiceLineStorage
    {
        static List<InvoiceLine> _invoiceLine = new List<InvoiceLine>()
        {
            new InvoiceLine
            {
                InvoiceLineId = 555,
                CustomerId = 1234,
                TrackId = 12,
                UnitPrice = 1,
                Quantity = 1
            }
        };
    }
}
