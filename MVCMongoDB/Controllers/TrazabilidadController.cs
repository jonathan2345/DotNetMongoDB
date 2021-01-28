using Microsoft.AspNetCore.Mvc;
using MVCMongoDB.Models;
using MVCMongoDB.Services;
using System.Collections.Generic;

namespace MVCMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrazabilidadController : ControllerBase
    {
        public LogService _logService;

        public TrazabilidadController(LogService logService)
        {
            _logService = logService;
        }

        [HttpGet]
        public ActionResult<List<Trazabilidad>> Get()
        {
            return _logService.Get();
        }

        [HttpPost]
        [Route("InsertarTraza")]
        public ActionResult<Trazabilidad> Create(Trazabilidad trazabilidad)
        {
            _logService.Create(trazabilidad);
            return Ok(trazabilidad);
        }
    }
}
