using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinookApp.DataAccess;
using ChinookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ChinookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GetInvoiceByAgentController : Controller
    {
        // storage ***
        private readonly GetInvoiceByAgentStorage _invoice;
        public GetInvoiceByAgentController(IConfiguration config)
        {
            _invoice = new GetInvoiceByAgentStorage(config);
        }
        // end storage ***

        // Get Invoice(s) by a Single Agent ***
        [HttpGet("{id}")]
        public IActionResult GetInvoiceByAgent(int id)
        {
             return Ok(_invoice.GetInvoiceByAgent(id));
        }
    }
}