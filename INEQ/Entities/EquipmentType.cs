using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EquipmentType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public float UseFulLife { get; set; }
        public float GuaranteeDuration { get; set; }
        public bool Active { get; set; }
    }
}
