using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChinookApp.Models
{
    // Provide an endpoint that shows the invoices associated with each sales agent. 
    // The result should include the Sales Agent's full name.
    public class GetInvoiceByAgentModel
    {
        public string CustomerName { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal Total { get; set; }
    }
}
