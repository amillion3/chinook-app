using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.DataAccess;
using ChinookApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChinookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SalesAgentController : Controller
    {
        // storage ***
        private readonly SalesAgentStorage _salesagents;
        public SalesAgentController()
        {
            _salesagents = new SalesAgentStorage();
        }
        // end storage ***

        // Get All Sales Agents ***
        [HttpGet]
        public ActionResult<IEnumerable<SalesAgentModel>> GetAllSalesAgents()
        {
            var storage = new SalesAgentStorage();
            var agents = storage.GetAllSalesAgents();
            return Ok(agents);
        }

        // Get Single Sales Agent ***
        [HttpGet("{id}")]
        public ActionResult<List<SalesAgentModel>> GetSalesAgent(int id)
        {
            var storage = _salesagents.GetAllSalesAgents();
            // var agent = storage.Where(s => s.EmployeeId == id);
            var agent = storage.Where(storag => storag.EmployeeId == id);

            return Ok(agent);
        }
    }
}