
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenDucAnh2410900002Exam.Models;

public class NdaEmployeesController : Controller
{
    private readonly NdaExamContext _context;

    public NdaEmployeesController(NdaExamContext context)
    {
        _context = context;
    }

    // GET: NDAEMPLOYEES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NdaEmployees.ToListAsync());
    }

    // GET: NDAEMPLOYEES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ndaemployee = await _context.NdaEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ndaemployee == null)
        {
            return NotFound();
        }

        return View(ndaemployee);
    }

    // GET: NDAEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NDAEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NdaName,NdaGender,NdaBirthDay,NdaEmail,NdaPhone,NdaActive")] NdaEmployee ndaemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ndaemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ndaemployee);
    }

    // GET: NDAEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ndaemployee = await _context.NdaEmployees.FindAsync(id);
        if (ndaemployee == null)
        {
            return NotFound();
        }
        return View(ndaemployee);
    }

    // POST: NDAEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NdaName,NdaGender,NdaBirthDay,NdaEmail,NdaPhone,NdaActive")] NdaEmployee ndaemployee)
    {
        if (id != ndaemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ndaemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NdaEmployeeExists(ndaemployee.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(ndaemployee);
    }

    // GET: NDAEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ndaemployee = await _context.NdaEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ndaemployee == null)
        {
            return NotFound();
        }

        return View(ndaemployee);
    }

    // POST: NDAEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var ndaemployee = await _context.NdaEmployees.FindAsync(id);
        if (ndaemployee != null)
        {
            _context.NdaEmployees.Remove(ndaemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NdaEmployeeExists(int? id)
    {
        return _context.NdaEmployees.Any(e => e.Id == id);
    }
}
