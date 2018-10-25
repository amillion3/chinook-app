using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChinookApp.Models
{
    // Provide an endpoint that shows the Invoice Total, Customer name, 
    //  Country and Sale Agent name for all invoices.
    public class GetAllInvoicesModel
    {
        public decimal InvoiceTotal { get; set; }
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public string AgentName { get; set; }
    }
}
