using Computer_Service.Entities;
using Computer_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Computer_Service.Services
{
    public interface ICsService
    {
        OrdersDTO GetById(int id);
        IEnumerable<OrdersDTO> GetAll();
        void Create(CreateOrderDTO dto);
        void Update(int id, UpdateOrderDTO dto);
    }
    public class CsService : ICsService
    {
        private readonly ServiceDBContext _dbContext;

        private readonly IMapper _mapper;

        public CsService(ServiceDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public OrdersDTO GetById(int id)
        {
            var order = _dbContext
                   .Orders
                   .FirstOrDefault(o => o.Id == id);

            var orderDTO = _mapper.Map<OrdersDTO>(order);

           

            return orderDTO;

        }

        public IEnumerable<OrdersDTO> GetAll()
        {
            var orders = _dbContext
               .Orders
               .ToList();

            var ordersDTOS = _mapper.Map<List<OrdersDTO>>(orders);
            return ordersDTOS;
        }

        public void Create(CreateOrderDTO dto)
        {
            var order = new Order
            {
                Description = dto.Description,
                Model = dto.Model,
                CustomerId = 1

            };
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        public void Update(int id, UpdateOrderDTO dto)
        {
            var order = _dbContext
                  .Orders
                  .FirstOrDefault(o => o.Id == id);

            order.Repair = dto.Repair;
            order.IsReady = dto.IsReady;
            _dbContext.SaveChanges();

            
        }
    }
}
