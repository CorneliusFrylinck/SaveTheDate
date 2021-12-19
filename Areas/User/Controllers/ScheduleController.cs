using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeddingAnniversary.Areas.User.Models;
using WeddingAnniversary.Data;

namespace WeddingAnniversary.Areas.User.Views
{
    [Area("User")]
    public class ScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User/Schedule
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.scheduleItems.Include(s => s.Schedule);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: User/Schedule/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleItem = await _context.scheduleItems
                .Include(s => s.Schedule)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduleItem == null)
            {
                return NotFound();
            }

            return View(scheduleItem);
        }

        // GET: User/Schedule/Create
        public IActionResult Create()
        {
            ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id");
            return View();
        }

        // POST: User/Schedule/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ScheduleId,ItemName,ItemDescription,ItemTime")] ScheduleItem scheduleItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduleItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", scheduleItem.ScheduleId);
            return View(scheduleItem);
        }

        // GET: User/Schedule/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleItem = await _context.scheduleItems.FindAsync(id);
            if (scheduleItem == null)
            {
                return NotFound();
            }
            ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", scheduleItem.ScheduleId);
            return View(scheduleItem);
        }

        // POST: User/Schedule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ScheduleId,ItemName,ItemDescription,ItemTime")] ScheduleItem scheduleItem)
        {
            if (id != scheduleItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduleItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleItemExists(scheduleItem.Id))
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
            ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", scheduleItem.ScheduleId);
            return View(scheduleItem);
        }

        // GET: User/Schedule/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleItem = await _context.scheduleItems
                .Include(s => s.Schedule)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduleItem == null)
            {
                return NotFound();
            }

            return View(scheduleItem);
        }

        // POST: User/Schedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scheduleItem = await _context.scheduleItems.FindAsync(id);
            _context.scheduleItems.Remove(scheduleItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleItemExists(int id)
        {
            return _context.scheduleItems.Any(e => e.Id == id);
        }
    }
}
