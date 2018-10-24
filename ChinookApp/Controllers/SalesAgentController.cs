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
    }
}