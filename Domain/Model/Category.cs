﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
