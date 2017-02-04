using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Component
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int ComponentTypeId { get; set; }
        public int EquipmentId { get; set; }
        public int EquipmentTypeId { get; set; }

    }
}
