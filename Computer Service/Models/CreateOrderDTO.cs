using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Service.Models
{
    public class CreateOrderDTO
    {
       
        public string Model { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
    }
}
