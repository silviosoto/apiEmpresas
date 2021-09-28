using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiEmpresa.Models;

namespace ApiEmpresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipiosController : ControllerBase
    {
        private readonly empresasContext _context;

        public MunicipiosController(empresasContext context)
        {
            _context = context;
        }

        // GET: api/Municipios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Municipio>>> GetMunicipio()
        {
            return await _context.Municipio.ToListAsync();
        }

        // GET: api/Municipios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Municipio>> GetMunicipio(int id)
        {
            var municipio = await _context.Municipio.FindAsync(id);

            if (municipio == null)
            {
                return NotFound();
            }

            return municipio;
        }

        // PUT: api/Municipios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMunicipio(int id, Municipio municipio)
        {
            if (id != municipio.Id)
            {
                return BadRequest();
            }

            _context.Entry(municipio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MunicipioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Municipios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Municipio>> PostMunicipio(Municipio municipio)
        {
            _context.Municipio.Add(municipio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMunicipio", new { id = municipio.Id }, municipio);
        }

        // DELETE: api/Municipios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Municipio>> DeleteMunicipio(int id)
        {
            var municipio = await _context.Municipio.FindAsync(id);
            if (municipio == null)
            {
                return NotFound();
            }

            _context.Municipio.Remove(municipio);
            await _context.SaveChangesAsync();

            return municipio;
        }

        private bool MunicipioExists(int id)
        {
            return _context.Municipio.Any(e => e.Id == id);
        }
    }
}
