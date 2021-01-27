using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonolegalTest.Models;
using MonolegalTest.Services;
using System.Text.Json;

namespace MonolegalTest.Controllers
{
    [Route("api/Factura")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        public FacturaService _facturaService;
        public FacturaController(FacturaService facturaService)
        {
            _facturaService = facturaService;
        }
        [Route("GetAllFactura")]
        [HttpGet]
        public object Get()
        {
           
            var json = JsonSerializer.Serialize(_facturaService.Get());
            return json;

        }
    }
}
