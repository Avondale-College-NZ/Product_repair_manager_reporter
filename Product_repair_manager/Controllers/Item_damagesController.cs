
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

public class Item_damagesController : Controller
{
    private readonly ProductrepairmanagerContext _context;

    public Item_damagesController(ProductrepairmanagerContext context)
    {
        _context = context;
    }

    // GET: ITEM_DAMAGESS
    public async Task<IActionResult> Index()    
    {
        var item = _context.Item_damages;
        return View(await _context.Item_damages.ToListAsync());
   
     }
    private void IssueForeignKeyDropdown(object selected = null)
    {
        var query = from i in _context.Item_damages
                    orderby i.ItemsId
                    select i;
        ViewBag.IssueID = new SelectList(query.AsNoTracking(), "ItemsId", "ItemsId", selected);
    }

    // GET: ITEM_DAMAGESS/Details/5
    public async Task<IActionResult> Details(int? item_damagesid)
    {
        if (item_damagesid == null)
        {
            return NotFound();
        }

        var item_damages = await _context.Item_damages
            .FirstOrDefaultAsync(m => m.Item_damagesId == item_damagesid);
        if (item_damages == null)
        {
            return NotFound();
        }

        return View(item_damages);
    }

    // GET: ITEM_DAMAGESS/Create
    public IActionResult Create()
    {
        IssueForeignKeyDropdown();
        return View();
    }

    // POST: ITEM_DAMAGESS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ItemsId,Item_damagesId,severity,damage_type,date,items,damages_reports")] Item_damages item_damages)
    {
        if (ModelState.IsValid)
        {
            _context.Add(item_damages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        IssueForeignKeyDropdown(item_damages.ItemsId);

        ViewData["ItemsId"] = new SelectList(_context.Items, "ItemsId", "ItemsId", item_damages.ItemsId);
        return View(item_damages);
    }

    // GET: ITEM_DAMAGESS/Edit/5
    public async Task<IActionResult> Edit(int? item_damagesid)
    {
        if (item_damagesid == null)
        {
            return NotFound();
        }

        var item_damages = await _context.Item_damages.FindAsync(item_damagesid);
        if (item_damages == null)
        {
            return NotFound();
        }
        IssueForeignKeyDropdown();
        return View(item_damages);
    }

    // POST: ITEM_DAMAGESS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? item_damagesid, [Bind("ItemsId,Item_damagesId,severity,damage_type,date,items,damages_reports")] Item_damages item_damages)
    {
        if (item_damagesid != item_damages.Item_damagesId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(item_damages);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Item_damagesExists(item_damages.Item_damagesId))
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
        ViewData["ItemsId"] = new SelectList(_context.Items, "ItemsId", "ItemsId", item_damages.ItemsId);
        return View(item_damages);
    }

    // GET: ITEM_DAMAGESS/Delete/5
    public async Task<IActionResult> Delete(int? item_damagesid)
    {
        if (item_damagesid == null)
        {
            return NotFound();
        }

        var item_damages = await _context.Item_damages
            .FirstOrDefaultAsync(m => m.Item_damagesId == item_damagesid);
        if (item_damages == null)
        {
            return NotFound();
        }

        IssueForeignKeyDropdown();
        return View(item_damages);
    }

    // POST: ITEM_DAMAGESS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? item_damagesid)
    {
        var item_damages = await _context.Item_damages.FindAsync(item_damagesid);
        if (item_damages != null)
        {
            _context.Item_damages.Remove(item_damages);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool Item_damagesExists(int? item_damagesid)
    {
        return _context.Item_damages.Any(e => e.Item_damagesId == item_damagesid);
    }
}
