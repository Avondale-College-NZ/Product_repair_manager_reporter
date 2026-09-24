
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

public class ItemsController : Controller
{
    private readonly ProductrepairmanagerContext _context;

    public ItemsController(ProductrepairmanagerContext context)
    {
        _context = context;
    }

    // GET: ITEMSS
    public async Task<IActionResult> Index()
    {
        var item = _context.Items;

        ViewBag.items = await _context.Items.ToListAsync();
        return View(await _context.Catagory.ToListAsync());
    }

    private void IssueForeignKeyDropdown(object selected = null)
    {
        var query = from i in _context.Items
                    orderby i.CatagoryId
                    select i;
        ViewBag.IssueID = new SelectList(query.AsNoTracking(), "CatagoryId", "CatagoryId", selected);
    }
    // GET: ITEMSS/Details/5
    public async Task<IActionResult> Details(int? itemsid)
    {
        if (itemsid == null)
        {
            return NotFound();
        }

        var items = await _context.Items
            .FirstOrDefaultAsync(m => m.ItemsId == itemsid);
        if (items == null)
        {
            return NotFound();
        }

        return View(items);
    }

    // GET: ITEMSS/Create
    public IActionResult Create()
    {
        if (ModelState.IsValid)
        {

        }
        ViewData["CatagoryId"] = new SelectList(_context.Set<Catagory>().OrderBy(i => i.Catagory_Name), "CatagoryId", "Catagory_Name");
        IssueForeignKeyDropdown();
        return View();
    }

    // POST: ITEMSS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CatagoryId,ItemsId,items_Name,Catagory,Item_damages")] Items items)
    {
        if (ModelState.IsValid)
        {
            _context.Add(items);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["CatagoryId"] = new SelectList(_context.Set<Catagory>().OrderBy(i => i.Catagory_Name), "CatagoryId", "Catagory_Name");
        IssueForeignKeyDropdown(items.CatagoryId);
        return View(items);
    }

    // GET: ITEMSS/Edit/5
    public async Task<IActionResult> Edit(int? itemsid)
    {
        if (itemsid == null)
        {
            return NotFound();
        }

        var items = await _context.Items.FindAsync(itemsid);
        if (items == null)
        {
            return NotFound();
        }
        return View(items);
    }

    // POST: ITEMSS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? itemsid, [Bind("CatagoryId,ItemsId,items_Name,Catagory,Item_damages")] Items items)
    {
        if (itemsid != items.ItemsId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(items);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemsExists(items.ItemsId))
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
        ViewData["CatagoryId"] = new SelectList(_context.Set<Catagory>().OrderBy(i => i.Catagory_Name), "CatagoryId", "Catagory_Name");
        return View(items);
    }

    // GET: ITEMSS/Delete/5
    public async Task<IActionResult> Delete(int? itemsid)
    {
        if (itemsid == null)
        {
            return NotFound();
        }

        var items = await _context.Items
            .FirstOrDefaultAsync(m => m.ItemsId == itemsid);
        if (items == null)
        {
            return NotFound();
        }

        return View(items);
    }

    // POST: ITEMSS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? itemsid)
    {
        var items = await _context.Items.FindAsync(itemsid);
        if (items != null)
        {
            _context.Items.Remove(items);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ItemsExists(int? itemsid)
    {
        return _context.Items.Any(e => e.ItemsId == itemsid);
    }
}
