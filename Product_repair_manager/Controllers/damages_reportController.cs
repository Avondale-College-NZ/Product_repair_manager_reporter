using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

namespace Product_repair_manager.Controllers
{
    public class damages_reportController : Controller
    {
        private readonly Product_repair_managerContext _context;

        public damages_reportController(Product_repair_managerContext context)
        {
            _context = context;
        }

        // GET: damages_report
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["fixed_reportSortParm"] = String.IsNullOrEmpty(sortOrder) ? "fixed_report" : "";
            ViewData["item_statusSortParm"] = sortOrder == "item_status" ? "Item_date" : "";
            ViewData["Item_dateSortParm"] = sortOrder == "Item_date" ? "" : "";

            var damages_report = from s in _context.damages_report
                                 select s;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                damages_report = damages_report.Where(s => s.fixed_report.Contains(searchString)
                                       || s.item_status.Contains(searchString)
                                       || s.Item_date.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                case "fixed_report":
                    damages_report = damages_report.OrderByDescending(s => s.fixed_report);
                    break;
                case "item_status":
                    damages_report = damages_report.OrderBy(s => s.item_status);
                    break;
                default:
                    damages_report = damages_report.OrderByDescending(s => s.Item_date);
                    break;
            }
            int pageSize = 15;
            return View(await PaginatedList<damages_report>.CreateAsync(damages_report.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        // GET: damages_report/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: damages_report/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: damages_report/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("damages_reportId,UserId,fixed_report,item_status,ClassId,Item_date,item_damages_id")] damages_report damages_report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(damages_report);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(damages_report);
        }

        // GET: damages_report/Edit/5
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

        // POST: damages_report/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("damages_reportId,UserId,fixed_report,item_status,ClassId,Item_date,item_damages_id")] damages_report damages_report)
        {
            if (id != damages_report.damages_reportId)
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
                    if (!damages_reportExists(damages_report.damages_reportId))
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

        // GET: damages_report/Delete/5
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

        // POST: damages_report/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var damages_report = await _context.damages_report.FindAsync(id);
            if (damages_report != null)
            {
                _context.damages_report.Remove(damages_report);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool damages_reportExists(int id)
        {
            return _context.damages_report.Any(e => e.damages_reportId == id);
        }
    }
}
