
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

public class damages_reportController : Controller
{
    private readonly ProductrepairmanagerContext _context;

    public damages_reportController(ProductrepairmanagerContext context)
    {
        _context = context;
    }

    // GET: DAMAGES_REPORTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.damages_report.ToListAsync());
    }

    // GET: DAMAGES_REPORTS/Details/5
    public async Task<IActionResult> Details(int? damages_reportid)
    {
        if (damages_reportid == null)
        {
            return NotFound();
        }

        var damages_report = await _context.damages_report
            .FirstOrDefaultAsync(m => m.damages_reportId == damages_reportid);
        if (damages_report == null)
        {
            return NotFound();
        }

        return View(damages_report);
    }

    // GET: DAMAGES_REPORTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: DAMAGES_REPORTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("damages_reportId,UserId,ClassesId,Item_damagesId,fixed_report,item_status,Item_date,appuser,classes,item_damages")] damages_report damages_report)
    {
        if (ModelState.IsValid)
        {
            _context.Add(damages_report);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(damages_report);
    }

    // GET: DAMAGES_REPORTS/Edit/5
    public async Task<IActionResult> Edit(int? damages_reportid)
    {
        if (damages_reportid == null)
        {
            return NotFound();
        }

        var damages_report = await _context.damages_report.FindAsync(damages_reportid);
        if (damages_report == null)
        {
            return NotFound();
        }
        return View(damages_report);
    }

    // POST: DAMAGES_REPORTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? damages_reportid, [Bind("damages_reportId,UserId,ClassesId,Item_damagesId,fixed_report,item_status,Item_date,appuser,classes,item_damages")] damages_report damages_report)
    {
        if (damages_reportid != damages_report.damages_reportId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(damages_report);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Damages_reportExists(damages_report.damages_reportId))
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
        return View(damages_report);
    }

    // GET: DAMAGES_REPORTS/Delete/5
    public async Task<IActionResult> Delete(int? damages_reportid)
    {
        if (damages_reportid == null)
        {
            return NotFound();
        }

        var damages_report = await _context.damages_report
            .FirstOrDefaultAsync(m => m.damages_reportId == damages_reportid);
        if (damages_report == null)
        {
            return NotFound();
        }

        return View(damages_report);
    }

    // POST: DAMAGES_REPORTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? damages_reportid)
    {
        var damages_report = await _context.damages_report.FindAsync(damages_reportid);
        if (damages_report != null)
        {
            _context.damages_report.Remove(damages_report);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool Damages_reportExists(int? damages_reportid)
    {
        return _context.damages_report.Any(e => e.damages_reportId == damages_reportid);
    }
}
