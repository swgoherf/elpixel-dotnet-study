using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Office.Api.Models;
using Office.Api.Data;

[Route("api/[controller]")]
[ApiController]
public class OfficeEntitiesController : ControllerBase
{
    private readonly OfficeDbContext _context;
    public OfficeEntitiesController(OfficeDbContext context)
    {
        _context = context;
    }

    // GET: api/OfficeEntity
    [HttpGet]
    public async Task<ActionResult<IEnumerable<OfficeEntity>>> GetOfficeEntity()
    {
        return await _context.Offices.ToListAsync();
    }

    // GET: api/OfficeEntity/5
    [HttpGet("{id}")]
    public async Task<ActionResult<OfficeEntity>> GetOfficeEntity(System.Guid id)
    {
        var officeentity = await _context.Offices.FindAsync(id);

        if (officeentity == null)
        {
            return NotFound();
        }

        return officeentity;
    }

    // PUT: api/OfficeEntity/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutOfficeEntity(System.Guid? id, OfficeEntity officeentity)
    {
        if (id != officeentity.Id)
        {
            return BadRequest();
        }

        _context.Entry(officeentity).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!OfficeEntityExists(id))
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

    // POST: api/OfficeEntity
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<OfficeEntity>> PostOfficeEntity(OfficeEntity officeentity)
    {
        _context.Offices.Add(officeentity);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetOfficeEntity", new { id = officeentity.Id }, officeentity);
    }

    // DELETE: api/OfficeEntity/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOfficeEntity(System.Guid? id)
    {
        var officeentity = await _context.Offices.FindAsync(id);
        if (officeentity == null)
        {
            return NotFound();
        }

        _context.Offices.Remove(officeentity);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool OfficeEntityExists(System.Guid? id)
    {
        return _context.Offices.Any(e => e.Id == id);
    }
}
