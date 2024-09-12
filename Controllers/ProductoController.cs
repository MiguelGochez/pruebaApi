using EjemploWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploWebApi.Controllers
{
    [Route("api/producto")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public readonly BbContext _bdContext;

        public ProductoController(BbContext bdContext)
        {
            _bdContext = bdContext;
        }

        [HttpGet]
        [Route("lista")]
        public IActionResult ObtenerProducto()
        {
            List<Producto> products = new List<Producto>();
            products = _bdContext.Producto.ToList();
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Oky", response = products });
        }
        [HttpPost]
        [Route("agregar")]
        public IActionResult AgregarProducto([FromBody]Producto producto)
        {
            _bdContext.Producto.Add(producto);
            _bdContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
