﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    internal class Context:DbContext
    {
        public Context(DbContextOptions options):base(options)
        {
            
        }
    }
}
