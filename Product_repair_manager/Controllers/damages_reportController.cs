
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Data;
using Product_repair_manager.Models;

[Authorize(Roles = "Admin")]
public class damages_reportController : Controller
{
    private readonly ProductrepairmanagerContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public damages_reportController(
    ProductrepairmanagerContext context,
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager)
    {
        _context = context;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    // GET: DAMAGES_REPORTS
    public async Task<IActionResult> Index()    
    {
        var damages = _context.damages_report;

        ViewBag.damages = await _context.Classes.ToListAsync();
        return View(await _context.damages_report.ToListAsync());
    }

    private void damagesreportForeignKeyDropdown(object selected = null)
    {
        var Classroom = from i in _context.damages_report
                    orderby i.ClassesId
                    select i;
        ViewBag.damages_report = new SelectList(Classroom.AsNoTracking(), "ClassesId", "blocks", selected);
        var Item_damages = from i in _context.damages_report
                     orderby i.Item_damagesId
                     select i;
        ViewBag.damages_report = new SelectList(Item_damages.AsNoTracking(), "Item_damagesId", "severity", selected);
        var User = from i in _context.damages_report
                      orderby i.Id
                      select i;
        ViewBag.damages_report = new SelectList(User.AsNoTracking(), "Id", "FirstName", selected);
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
        if (damages_reportid == null)
        {
            return NotFound();
        }

        return View(damages_report);
    }

    // GET: DAMAGES_REPORTS/Create
    public IActionResult Create()
    {
        if (ModelState.IsValid)
        {
            
        }
        ViewData["ClassesId"] = new SelectList(_context.Set<Classes>().OrderBy(i=>i.blocks), "ClassesId", "blocks");
        ViewData["Item_damagesId"] = new SelectList(_context.Set<Item_damages>().OrderBy(i => i.severity), "Item_damagesId", "severity");
        ViewData["Id"] = new SelectList(_context.Set<ApplicationUser>().OrderBy(i => i.FirstName), "Id", "FirstName");
        return View();
    }

    // POST: DAMAGES_REPORTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
    [Bind("damages_reportId,ClassesId,Item_damagesId,fixed_report,item_status,Item_date")]
    damages_report damages_report)
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return Challenge();
        }

        // Assign the logged-in user's ID before validation
        damages_report.Id = user.Id;
        damages_report.appuser = user;

        // Remove validation errors for Id if it wasn't submitted in the form
        ModelState.Remove(nameof(damages_report.Id));
        ModelState.Remove(nameof(damages_report.appuser));

        if (ModelState.IsValid)
        {
            _context.damages_report.Add(damages_report);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        ViewData["ClassesId"] = new SelectList(
            _context.Set<Classes>().OrderBy(i => i.blocks),
            "ClassesId", "blocks", damages_report.ClassesId);

        ViewData["Item_damagesId"] = new SelectList(
            _context.Set<Item_damages>().OrderBy(i => i.severity),
            "Item_damagesId", "severity", damages_report.Item_damagesId);

        return View(damages_report);
    }

    // GET: DAMAGES_REPORTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var damages_report = await _context.damages_report.FindAsync(id);
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
    public async Task<IActionResult> Edit(int damages_reportid, [Bind("damages_reportId,UserId,ClassesId,Item_damagesId,fixed_report,item_status,Item_date,appuser,classes,item_damages")] damages_report damages_report)
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
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var damages_report = await _context.damages_report
            .FirstOrDefaultAsync(m => m.damages_reportId == id);
        if (damages_report == null)
        {
            return NotFound();
        }

        return View(damages_report);
    }

    // POST: DAMAGES_REPORTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var damages_report = await _context.damages_report.FindAsync(id);
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
