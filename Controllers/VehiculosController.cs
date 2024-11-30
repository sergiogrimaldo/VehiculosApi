using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using VehiculosAPI.Data;

namespace VehiculosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly VehiculosDbContext _context;

        public VehiculosController(VehiculosDbContext context)
        {
            _context = context;
        }

        [HttpGet("ObtenerSumaValores")]
        public IActionResult ObtenerSumaValores()
        {
            var resultados = _context.Vehiculos
                .FromSqlRaw("EXEC ObtenerSumaValores")
                .ToList();

            return Ok(resultados);
        }
    }
}
