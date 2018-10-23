using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChinookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesAgentController : Controller
    {
        [HttpGet("salesagents")]
        public ActionResult GetAllSalesAgents()
        {
            return Ok();
        }
    }
}