using CarpinteriaApp.datos;
using CarpinteriaApp.dominio;
using CarpinteriaApp.Servicios;
using CarpinteriaApp.Servicios.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carpinteriaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestosController : ControllerBase
    {
        public IServicio servicio;

        public PresupuestosController()
        {
            FabricaServicio fabrica = new FabricaServicioImp();
            servicio =  fabrica.CrearServicio();
        }

        // GET: api/<PresupuestosController>
        [HttpGet("/productos")]
        public IActionResult GetProductos()
        {
            List<Producto> lst = null;
            try
            {
                lst = servicio.ObtenerProductos();
                return Ok(lst);
            }
            catch (Exception)
            {
                return  StatusCode(500,"errorinterno");                
            }
        }

        // GET api/<PresupuestosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PresupuestosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PresupuestosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PresupuestosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
