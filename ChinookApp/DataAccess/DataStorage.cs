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
        //static List <InvoiceModel> _invoice = new List<InvoiceModel>();
        //private const string ConnectionString = "Server=(local);Database=hihihihi;Trusted_Connection=True;";
        
        //public bool addInvoice(InvoiceModel invoice)
        //{
        //    using (var db = new SqlConnection(ConnectionString)) 
        //    {
        //        db.Open();
        //        var command = db.CreateCommand();
        //        command.commandText = @"INSERT INTO [dbo].[Invoice]
        //            ([Name],[Color],[MaxFeetPerSecond],[Size],[Sex])
        //            VALUES (@Name,@Color,@MaxFeet,@Size,@Sex)";
        //    }
        //}
    }
}
