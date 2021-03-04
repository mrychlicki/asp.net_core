using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Service.Models
{
    public class OrdersDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Repair { get; set; }
        public bool IsReady { get; set; }
    }
}
