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

        private const string ConnectionString = "Server=(local);Database=Chinook;Trusted_Connection=True;";

        //public bool AddSalesAgent(SalesAgentModel salesAgent)
        //{
        //    using (var db = new SqlConnection(ConnectionString))
        //    {
        //        db.Open();
        //        var command = db.CreateCommand();
        //        //command.CommandText = @"INSERT INTO [dbo].[SalesAgents]
        //        //    ([Name],[Color],[MaxFeetPerSecond],[Size],[Sex])
        //        //    VALUES (@Name,@Color,@MaxFeet,@Size,@Sex)";
        //        //command.Parameters.AddWithValue("@name", rabbit.Name);

        //    }
        //}
    }
}
