using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChinookApp.Models
{
    public class InvoiceLine
    {
        public int InvoiceLineId { get; set; }
        public int CustomerId { get; set; }
        public int TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
