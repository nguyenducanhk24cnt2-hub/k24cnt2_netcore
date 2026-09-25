using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NdaFirstDatabase.Models;

public class NdaMembersController : Controller
{
    private readonly NdaLesson10EfContext _context;

    public NdaMembersController(NdaLesson10EfContext context)
    {
        _context = context;
    }

    // GET: NdaMembers
    public async Task<IActionResult> Index()
    {
        return View(await _context.NdaMembers.ToListAsync());
    }

    // GET: NdaMembers/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ndamember = await _context.NdaMembers
            .FirstOrDefaultAsync(m => m.NdaId == id);
        if (ndamember == null)
        {
            return NotFound();
        }

        return View(ndamember);
    }

    // GET: NdaMembers/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NdaMembers/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("NdaUserName,NdaPassword,NdaFullName,NdaEmail,NdaPhone,NdaStatus")] NdaMember ndamember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ndamember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ndamember);
    }

    // GET: NdaMembers/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ndamember = await _context.NdaMembers.FindAsync(id);
        if (ndamember == null)
        {
            return NotFound();
        }
        return View(ndamember);
    }

    // POST: NdaMembers/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("NdaId,NdaUserName,NdaPassword,NdaFullName,NdaEmail,NdaPhone,NdaStatus")] NdaMember ndamember)
    {
        if (id != ndamember.NdaId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ndamember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NdaMemberExists(ndamember.NdaId))
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
        return View(ndamember);
    }

    // GET: NdaMembers/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ndamember = await _context.NdaMembers
            .FirstOrDefaultAsync(m => m.NdaId == id);
        if (ndamember == null)
        {
            return NotFound();
        }

        return View(ndamember);
    }

    // POST: NdaMembers/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        var ndamember = await _context.NdaMembers.FindAsync(id);
        if (ndamember != null)
        {
            _context.NdaMembers.Remove(ndamember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NdaMemberExists(long id)
    {
        return _context.NdaMembers.Any(e => e.NdaId == id);
    }
}