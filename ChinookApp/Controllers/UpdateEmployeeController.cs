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

    public class UpdateEmployeeController : ControllerBase
    {
        private readonly UpdateEmployeeStorage _update;
        public UpdateEmployeeController()
        {
            _update = new UpdateEmployeeStorage();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, string first, string last)
        {
            return Ok(_update.UpdateEmployee(id, first, last));
        }

    }
}