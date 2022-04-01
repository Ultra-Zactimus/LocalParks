using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalPark.Models;

namespace LocalPark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly LocalParkContext _db;

    public ParksController(LocalParkContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string city, string trails, string notes)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }    

      if (trails != null)
      {
        query = query.Where(entry => entry.Trails == trails);
      }      

      if (notes != null)
      {
        query = query.Where(entry => entry.Notes == notes);
      }      

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
        var park = await _db.Parks.FindAsync(id);

        if (park == null)
        {
            return NotFound();
        }

        return park;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(existence => existence.ParkId == id);
    }
  }
}