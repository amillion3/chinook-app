using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class DataStorage
    {
        static List <Invoice> _invoice = new List<Invoice>();
        private const string ConnectionString = "Server=(local);Database=hihihihi;Trusted_Connection=True;";
        
        public bool addInvoice(Invoice invoice)
        {
            using (var db = new SqlConnection(ConnectionString)) 
            {
                return Ok();
            }
        }
    }
}
