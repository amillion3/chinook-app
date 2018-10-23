using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.Models;

namespace ChinookApp.DataAccess
{
    public class SalesAgentStorage
    {
        static List<SalesAgent> _salesAgent = new List<SalesAgent>()
        {
            new SalesAgent
            {
                EmployeeId = 123456,
                FirstName = "Steve-O",
                LastName = "Smite",
                Title = "Sales Support Agent"
            }
        };
    }
}
