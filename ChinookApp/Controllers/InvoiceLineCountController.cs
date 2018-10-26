using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChinookApp.DataAccess;


namespace ChinookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceLineCountController : Controller
    {
        private readonly InvoiceLineCountStorage _linecount;
        public InvoiceLineCountController()
        {
            _linecount = new InvoiceLineCountStorage();
        }

        // Count Invoice Lines Per Invoice Id
        [HttpGet("{id}")]
        public IActionResult InvoiceLineCount(int id)
        {
            return Ok(_linecount.InvoiceLineCount(id));
        }
    }
}