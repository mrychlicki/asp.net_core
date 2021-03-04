using Computer_Service.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Computer_Service.Models;
using Computer_Service.Services;

namespace Computer_Service.Controllers
{
    [Route("/EditOrder")]
    public class EditOrderController : Controller 
    {
        
        private readonly ICsService _csService;
        private int _id;
        public EditOrderController(ICsService csService)
        {
            _csService = csService;
        }

        [HttpGet("{id}")]
        public ActionResult<OrdersDTO> Index([FromRoute]int id)
        {
            _id = id;

            var orderDTO = _csService.GetById(id);
            return View("index", orderDTO);
        }

        //[HttpPost]
        //public ActionResult Post([FromQuery] bool _IsReady, [FromQuery] string _Repair)
        //{
        //    var updateOrderDTO = new UpdateOrderDTO()
        //    {
        //        IsReady = _IsReady,
        //        Repair = _Repair
        //    };
        //   _csService.Update(1, updateOrderDTO);

        //        return RedirectToAction("index", "Home");

        //}

        [HttpPost("{id}")]
        public ActionResult Update([FromBody]OrdersDTO dto)
        {
            var _dto = new UpdateOrderDTO()
            {
                IsReady = dto.IsReady,
                Repair = dto.Repair
            };
            _csService.Update(1, _dto);
            return RedirectToAction("index", "Home");
        }
    }
}
