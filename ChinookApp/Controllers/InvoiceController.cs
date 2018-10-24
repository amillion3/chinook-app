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

    public class InvoiceController : Controller
    {
        // storage ***
        private readonly InvoiceStorage _invoice;
        public InvoiceController()
        {
            _invoice = new InvoiceStorage();
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