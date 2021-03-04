using Computer_Service.Entities;
using Computer_Service.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Computer_Service.Services;

namespace Computer_Service.Controllers
{
    [Route("/Customer")]
    public class CustomerController : Controller
    {
        private readonly ICsService _csService;

        public CustomerController(ICsService csService)
        {
            _csService = csService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("CustomerLoginView");
        }

        [HttpPost]
        public ActionResult<IQueryable<Order>> Post(CreateOrderDTO dto)
        {
            _csService.Create(dto);
            return View("Index");
        }
     
    }
}
