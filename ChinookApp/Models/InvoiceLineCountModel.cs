using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChinookApp.Models
{
    // Looking at the InvoiceLine table, provide an endpoint that COUNTs the number 
    //  of line items for an Invoice with a parameterized Id from user input.
    // HINT, this could use `ExecuteScalar`
    public class InvoiceLineCountModel
    {
        public int LineItemCount { get; set; }
    }
}
