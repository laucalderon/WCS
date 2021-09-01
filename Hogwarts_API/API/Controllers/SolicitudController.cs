using API.Models;
using AutoMapper;
using DATOS;
using Hogwarts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    /// <summary>
    /// Controladora para la gestión de solicitudes de inscripción
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        private readonly IHogwarts<Solicitud> _h;
        private readonly IMapper _mapper;
        public SolicitudController(IHogwarts<Solicitud> h, IMapper mapper)
        {
            _h = h;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtiene el listado de solicitudes de inscripción
        /// </summary>
        /// <returns>Retorna listado de solicitudes de inscripción</returns>           
        /// <response code="200">OK. Se listan las solicitudes correctamente.</response>        
        /// <response code="404">No se han encontrado solicitudes.</response>    
        /// <response code="500">Ha ocurrido un error interno.</response>   
        // GET: api/<SolicitudController>
        [HttpGet]
        public ActionResult<IEnumerable<SolicitudResponse>>  GetAllSolicitudes()
        {
            var list = _h.Listado();            
            return Ok(_mapper.Map<IEnumerable<SolicitudResponse>>(list));
        }

        /// <summary>
        /// Obtiene una solicitud de inscripción
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna una solicitud de inscripción</returns>
        /// <response code="200">OK. Se muestra la solicitud correctamente.</response>        
        /// <response code="404">No se ha encontrado la solicitud.</response>    
        /// <response code="500">Ha ocurrido un error interno.</response> 
        // GET api/<SolicitudController>/5
        [HttpGet("{id}")]
        public ActionResult<SolicitudResponse> GetSolicitud(int id)
        {
            var solic=_h.Consultar(id);
            return Ok(_mapper.Map<SolicitudResponse>(solic));
        }

        /// <summary>
        /// Agrega una solicitud de inscripción
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Retorna la solicitud de inscripción</returns>
        /// <response code="200">OK. Se ha agregado la solicitud correctamente.</response> 
        /// <response code="500">Ha ocurrido un error interno.</response> 
        // POST api/<SolicitudController>
        [HttpPost]
        public ActionResult<SolicitudResponse> PostSolicitud([FromBody] SolicitudRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var solic= _mapper.Map<Solicitud>(model);
            var solBD=_h.Enviar(solic);
            return Ok(_mapper.Map<SolicitudResponse>(solBD));
        }

        /// <summary>
        /// Actualiza una solicitud de inscripción
        /// </summary>
        /// <returns>Retorna la solicitud de inscripción</returns>
        /// <response code="200">OK. Se ha editado la solicitud correctamente.</response>    
        /// <response code="500">Ha ocurrido un error interno.</response> 
        // PUT api/<SolicitudController>/5
        [HttpPut]
        public ActionResult<SolicitudResponse> PutSolicitud([FromBody] SolicitudUpdate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var solic = _mapper.Map<Solicitud>(model);
           var solBD= _h.Actualizar(solic);
            return Ok(_mapper.Map<SolicitudResponse>(solBD));
        }

        /// <summary>
        /// Elimina una solicitud de inscripción
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">OK. Se ha eliminado la solicitud correctamente.</response>        
        /// <response code="404">No se ha encontrado la solicitud.</response>    
        /// <response code="500">Ha ocurrido un error interno.</response> 
        // DELETE api/<SolicitudController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _h.Eliminar(id);
        }
    }
}
