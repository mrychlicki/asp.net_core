using Computer_Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Service
{
    public class OrderSeeder
    {
        private readonly ServiceDBContext _dbContext;
        public OrderSeeder(ServiceDBContext dBContext )
        {
            _dbContext = dBContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Orders.Any())
                {
                    var orders = GetOrders();
                    _dbContext.Orders.AddRange(orders);
                    _dbContext.SaveChanges();
                }
            }

        }

        private IEnumerable<Order> GetOrders()
        {
            var orders = new List<Order>()
            {
                new Order()
                {
                    Model ="HP 840 G3",
                    Description="opis",
                    IsReady = false,
                    Customer = new Customer()
                    {
                        Name="Mateusz",
                        Surname="R",
                        Login="mr",
                        Email ="mr@mr.pl",
                    }

                },

            new Order()
            {
                Model = "Lenovo g50-80",
                Description = "opis1",
                IsReady = true,
                Repair="wymiana płyty",
                Customer = new Customer()
                {
                    Name = "Adam",
                    Surname = "Nowak",
                    Login = "an",
                    Email = "an@an.pl",
                }

            }
            };

            return orders;
        }
    }
}
