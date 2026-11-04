
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

[Authorize(Roles = "Admin , Staff")]
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
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var catagory = await _context.Catagory
            .FirstOrDefaultAsync(m => m.CatagoryId == id);
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
    //this will create a new catagory and save it to the database if the model state is valid
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
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var catagory = await _context.Catagory.FindAsync(id);
        if (catagory == null)
        {
            return NotFound();
        }
        return View(catagory);
    }

    // POST: CATAGORYS/Edit/5
    //this will edit a catagory and save it to the database if the model state is valid
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
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var catagory = await _context.Catagory
            .FirstOrDefaultAsync(m => m.CatagoryId == id);
        if (catagory == null)
        {
            return NotFound();
        }

        return View(catagory);
    }

    // POST: CATAGORYS/Delete/5
    //this will delete a catagory and save it to the database if the model state is valid
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
