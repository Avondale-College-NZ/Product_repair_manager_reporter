
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

public class ClassesController : Controller
{
    private readonly ProductrepairmanagerContext _context;

    public ClassesController(ProductrepairmanagerContext context)
    {
        _context = context;
    }

    // GET: CLASSESS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Classes.ToListAsync());
    }

    // GET: CLASSESS/Details/5
    public async Task<IActionResult> Details(int? classesid)
    {
        if (classesid == null)
        {
            return NotFound();
        }

        var classes = await _context.Classes
            .FirstOrDefaultAsync(m => m.ClassesId == classesid);
        if (classes == null)
        {
            return NotFound();
        }

        return View(classes);
    }

    // GET: CLASSESS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CLASSESS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ClassesId,blocks,classroom,damages_reports")] Classes classes)
    {
        if (ModelState.IsValid)
        {
            _context.Add(classes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(classes);
    }

    // GET: CLASSESS/Edit/5
    public async Task<IActionResult> Edit(int? classesid)
    {
        if (classesid == null)
        {
            return NotFound();
        }

        var classes = await _context.Classes.FindAsync(classesid);
        if (classes == null)
        {
            return NotFound();
        }
        return View(classes);
    }

    // POST: CLASSESS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? classesid, [Bind("ClassesId,blocks,classroom,damages_reports")] Classes classes)
    {
        if (classesid != classes.ClassesId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(classes);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassesExists(classes.ClassesId))
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
        return View(classes);
    }

    // GET: CLASSESS/Delete/5
    public async Task<IActionResult> Delete(int? classesid)
    {
        if (classesid == null)
        {
            return NotFound();
        }

        var classes = await _context.Classes
            .FirstOrDefaultAsync(m => m.ClassesId == classesid);
        if (classes == null)
        {
            return NotFound();
        }

        return View(classes);
    }

    // POST: CLASSESS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? classesid)
    {
        var classes = await _context.Classes.FindAsync(classesid);
        if (classes != null)
        {
            _context.Classes.Remove(classes);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ClassesExists(int? classesid)
    {
        return _context.Classes.Any(e => e.ClassesId == classesid);
    }
}
