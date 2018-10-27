using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ChinookApp.DataAccess;
using ChinookApp.Models;

namespace ChinookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllInvoicesController : ControllerBase
    {
        private readonly GetAllInvoicesStorage _invoices;
        public GetAllInvoicesController(IConfiguration config)
        {
            _invoices = new GetAllInvoicesStorage(config);
        }

        // Get All Invoices
        [HttpGet]
        public IActionResult GetAllInvoices()
        {
            return Ok(_invoices.GetAllInvoices());
        }
    }
}