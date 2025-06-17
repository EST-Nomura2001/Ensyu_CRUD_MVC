using Ensyu_CRUD_MVC.Data;
using Ensyu_CRUD_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ensyu_CRUD_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        public readonly AppDbContext _context;
        public ToDosController(AppDbContext context)
        { 
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_context.ToDos.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> Post(ToDo toDo)
        {
            _context.ToDos.Add(toDo);
            _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get),new {id = toDo.Id},toDo);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var toDo = await _context.ToDos.FindAsync(id);
            if (toDo == null)
                return NotFound();
            _context.ToDos.Remove(toDo);
            _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,ToDo toDo)
        {
            if(!(id==toDo.Id))
                return BadRequest();

            _context.Entry(toDo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
