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
        static List<SalesAgentModel> _salesagents = new List<SalesAgentModel>()
        {
            new SalesAgentModel
            {
                EmployeeId = 123456,
                FirstName = "Steve-O",
                LastName = "Smite",
                Title = "Sales Support Agent"
            }
        };

        public IEnumerable<SalesAgentModel> GetAllSalesAgents()
        {
            return _salesagents;
        }

        public IEnumerable<SalesAgentModel> GetSalesAgent(int id)
        {
            // what is yield return and why does it work?
            yield return _salesagents.First(i => i.EmployeeId == id);
        }
    }
}
