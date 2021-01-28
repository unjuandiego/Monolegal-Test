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

        //listar todas las facturas
        [Route("GetAllFactura")]
        [HttpGet]
        public object Get()
        {
           
            var json = JsonSerializer.Serialize(_facturaService.Get());
            return json;

        }
        //Enviar Correo, [prueba]
        [Route("GetAllEmail")]
        [HttpGet]
        public async void Email(string estado)
        {
            await _emailSender
                .SendEmailAsync("juandiegoarboleda@utp.edu.co", "Estado De Su Factura", estado)
                .ConfigureAwait(false);
        }


        [Route("Update")]
        [HttpGet]
        public  object Update()

        {
             _facturaService.UpdateEstado();
            //Devolver Base dedatos con Estado actualizado
            var json = JsonSerializer.Serialize(_facturaService.Get());
            return json;

        }
        [Route("EstadoEmail")]
        [HttpGet]
        public object EstadoEmail()

        {
            if (_facturaService.FindEstado("primerrecordatorio") == true)
            {
                Email("Primer recordatorio");
            }
            else if(_facturaService.FindEstado("segundorecordatorio") == true)
            {
                Email("Segundo recordatorio");
            }
            else if (_facturaService.FindEstado("desactivado") == true)
            {
                Email("Desactivado");
            }            
            //Devolver Base dedatos con Estado actualizado
            var json = JsonSerializer.Serialize(_facturaService.Get());
            return json;

        }
    }
}
