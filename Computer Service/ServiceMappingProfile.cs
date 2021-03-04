using AutoMapper;
using Computer_Service.Entities;
using Computer_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Service
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            CreateMap<Order, OrdersDTO>();
            CreateMap<CreateOrderDTO, Order>();
        }
    }
}
