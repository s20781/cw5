using cw5.Models;
using cw5.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WareHousesController : ControllerBase
    {
        private readonly IWarehoueService _service;
        public WareHousesController(IWarehoueService warehouseService)
        {
            _service = warehouseService;
        }
        
        
        [HttpPost]

        public async Task<IActionResult> CreateWarehouse(WarehousePost warehousePost)
        {

            return Ok();


        }
    }
}
