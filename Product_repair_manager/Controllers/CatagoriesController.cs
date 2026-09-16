
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

public class CatagoriesController : Controller
{
    private readonly ProductrepairmanagerContext _context;

    public CatagoriesController(ProductrepairmanagerContext context)
    {
        _context = context;
    }

    // GET: CATAGORYS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Catagory.ToListAsync());
    }

    // GET: CATAGORYS/Details/5
    public async Task<IActionResult> Details(int? catagoryid)
    {
        if (catagoryid == null)
        {
            return NotFound();
        }

        var catagory = await _context.Catagory
            .FirstOrDefaultAsync(m => m.CatagoryId == catagoryid);
        if (catagory == null)
        {
            return NotFound();
        }

        return View(catagory);
    }

    // GET: CATAGORYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CATAGORYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CatagoryId,Catagory_Name,Items")] Catagory catagory)
    {
        if (ModelState.IsValid)
        {
            _context.Add(catagory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(catagory);
    }

    // GET: CATAGORYS/Edit/5
    public async Task<IActionResult> Edit(int? catagoryid)
    {
        if (catagoryid == null)
        {
            return NotFound();
        }

        var catagory = await _context.Catagory.FindAsync(catagoryid);
        if (catagory == null)
        {
            return NotFound();
        }
        return View(catagory);
    }

    // POST: CATAGORYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? catagoryid, [Bind("CatagoryId,Catagory_Name,Items")] Catagory catagory)
    {
        if (catagoryid != catagory.CatagoryId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(catagory);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatagoryExists(catagory.CatagoryId))
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
        return View(catagory);
    }

    // GET: CATAGORYS/Delete/5
    public async Task<IActionResult> Delete(int? catagoryid)
    {
        if (catagoryid == null)
        {
            return NotFound();
        }

        var catagory = await _context.Catagory
            .FirstOrDefaultAsync(m => m.CatagoryId == catagoryid);
        if (catagory == null)
        {
            return NotFound();
        }

        return View(catagory);
    }

    // POST: CATAGORYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? catagoryid)
    {
        var catagory = await _context.Catagory.FindAsync(catagoryid);
        if (catagory != null)
        {
            _context.Catagory.Remove(catagory);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CatagoryExists(int? catagoryid)
    {
        return _context.Catagory.Any(e => e.CatagoryId == catagoryid);
    }
}
