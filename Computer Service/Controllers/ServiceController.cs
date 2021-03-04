using AutoMapper;
using Computer_Service.Entities;
using Computer_Service.Models;
using Computer_Service.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Service.Controllers
{
    public class ServiceController : Controller
    {
       
        private readonly ICsService _csService;

        public ServiceController(ICsService csService )
        {
            _csService = csService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult<OrdersDTO> Index(ServiceModel service)
        {
         

            var ordersDTOS =_csService.GetAll();

            if (service.Login=="serwis")
            return View("ServiceLoginView", ordersDTOS);

            return RedirectToAction("index", "Home");
        }
    }
}
