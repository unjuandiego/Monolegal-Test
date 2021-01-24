using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonolegalTest.Models;
using MonolegalTest.Services;

namespace MonolegalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        public FacturaService _facturaService;
        public FacturaController(FacturaService facturaService)
        {
            _facturaService = facturaService;
        }
        [HttpGet]
        public ActionResult<List<Factura>> Get()
        {
            return _facturaService.Get();
        }
    }
}
