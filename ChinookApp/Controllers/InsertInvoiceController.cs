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

    public class InsertInvoiceController : ControllerBase
    {
        private readonly InsertInvoiceStorage _newInvoice;
        public InsertInvoiceController()
        {
            _newInvoice = new InsertInvoiceStorage();
        }
        [HttpPost]
        public IActionResult InsertInvoice(int id, DateTime date, string address, string city, string state, string country, string zip, decimal total)
        {
            return Ok(_newInvoice.InsertInvoice(id, date, address, city, state, country, zip, total));
        }
    }
}