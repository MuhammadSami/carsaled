﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsales.Web.Models
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
