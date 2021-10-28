using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Product : BaseModel
    {
        public int SortOrder { get; set; }
        public string Name { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
