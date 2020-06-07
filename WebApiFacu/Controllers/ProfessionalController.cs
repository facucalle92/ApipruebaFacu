using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiFacu.WebAPi.Data;
using WebApiFacu.WebAPi.Data.Entities;

namespace WebApiFacu.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalController : ControllerBase
    {
        private readonly ApiContext context;

        public ProfessionalController(ApiContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Professional>> Get()
        {
            return context.Profesionales.ToList();
        }
        [HttpGet ("{id}", Name = "ObtenerProfesioalPorId")]
        public ActionResult<Professional> Get(int id)
        {
            var profesional = context.Profesionales.FirstOrDefault(p => p.Id == id);
            if (profesional == null)
            {
                return NotFound("Id de Profesional Inválido");
            }
            return profesional;
        }
        [HttpPost]
        public ActionResult<Professional> Post ([FromBody] Professional prof)
        {
            context.Profesionales.Add(prof);
            context.SaveChanges();
            return new CreatedAtRouteResult("Profesional por id", new { id = prof.Id }, prof);
        }
        [HttpPut("{id}")]
        public ActionResult<Professional> Put(int id, [FromBody] Professional prof)
        {
            if ( id != prof.Id)
            {
                return BadRequest("Id inválido");
            }
            context.Entry(prof).State = EntityState.Modified;
            context.SaveChanges();
            return Ok("Cambio Correcto");
        }
        [HttpDelete("{id}")]
        public ActionResult<Professional> Delete(int id)
        {
            var profesional = context.Profesionales.FirstOrDefault(prof => prof.Id == id);
            if (profesional == null)
            {
                return NotFound("Id invalido");
            }
            context.Profesionales.Remove(profesional);
            context.SaveChanges();
            return Ok("Profesional Borrado");
        }
    }
    
}
