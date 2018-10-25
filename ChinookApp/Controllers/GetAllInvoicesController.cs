using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChinookApp.DataAccess;

namespace ChinookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllInvoicesController : ControllerBase
    {
        private readonly GetAllInvoicesStorage _invoices;
        public GetAllInvoicesController()
        {
            _invoices = new GetAllInvoicesStorage();
        }

        // Get All Invoices
        [HttpGet]
        public IActionResult GetAllInvoices()
        {
            return Ok(_invoices.GetAllInvoices());
        }
    }
}