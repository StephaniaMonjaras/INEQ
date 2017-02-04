using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Equipment
    {
        public int id { get; set; }
        public int EquipmentTypeId { get; set; }
        public int ModelId { get; set; }
        public int BrandId { get; set; }
        public int StatusId { get; set; }
        public int WarehouseId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Serie { get; set; }
        public string SofttekId { get; set; }
        public bool Active { get; set; }
    }
}
