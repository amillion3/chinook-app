﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChinookApp.Models
{
    // Provide a new endpoint to UPDATE an Employee's name with a 
    //  parameter for Employee Id and new name
    public class UpdateEmployeeModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
