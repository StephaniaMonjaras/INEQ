using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Model
    {
        public int ID { get;set;}
        public string Description { get; set; }
        public bool Active { get; set; }
        public int BrandId { get; set; }


    }
}
