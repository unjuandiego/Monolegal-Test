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
        private readonly IEmailSender _emailSender;
        public FacturaController(FacturaService facturaService, IEmailSender emailSender)
        {
            _facturaService = facturaService;
            _emailSender = emailSender;
        }
        [Route("GetAllFactura")]
        [HttpGet]
        public object Get()
        {
           
            var json = JsonSerializer.Serialize(_facturaService.Get());
            return json;

        }
        [Route("GetAllEmail")]
        [HttpGet]
        public async void Index()
        {
            await _emailSender
                .SendEmailAsync("juandiegoarboleda@utp.edu.co", "VERSION PRUEBA", "Esto es una prueba")
                .ConfigureAwait(false);
        }
        [Route("GetAll1")]
        [HttpGet]
        public  object Update()

        {
             _facturaService.Getprimer();
            var json = JsonSerializer.Serialize(_facturaService.Get());
            return json;

        }
        /*public object Get1()
        {

            var json = JsonSerializer.Serialize(_facturaService.Get());
            return json;

        }*/

    }
}
