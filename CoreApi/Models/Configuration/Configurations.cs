﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Models.Configuration
{
    public class Configurations
    {
        public string Environment { get; set; }
        public EnvironmentConfig EnvironmentConfig { get; set; }
    }
}
