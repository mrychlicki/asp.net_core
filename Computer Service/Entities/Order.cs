using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Service.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Repair { get; set; }
        public bool IsReady { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }


    }
}
