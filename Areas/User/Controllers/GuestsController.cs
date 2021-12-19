using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeddingAnniversary.Areas.User.Models;
using WeddingAnniversary.Data;

namespace WeddingAnniversary.Areas.User.Controllers
{
    [Area("User")]
    public class GuestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User/Guests
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.guests.Include(g => g.GuestList);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: User/Guests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.guests
                .Include(g => g.GuestList)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guest == null)
            {
                return NotFound();
            }

            return View(guest);
        }

        // GET: User/Guests/Create
        public IActionResult Create()
        {
            ViewData["GuestListId"] = new SelectList(_context.guestLists, "Id", "Id");
            ViewData["NotesId"] = new SelectList(_context.notes, "Id", "Id");
            return View();
        }

        // POST: User/Guests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Email,AllowedPusOne,GuestListId,RSVP,PlusOne,PlusOneName,PlusOneSurname,NotesId")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GuestListId"] = new SelectList(_context.guestLists, "Id", "Id", guest.GuestListId);
            //ViewData["NotesId"] = new SelectList(_context.notes, "Id", "Id", guest.NotesId);
            return View(guest);
        }

        // GET: User/Guests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.guests.FindAsync(id);
            if (guest == null)
            {
                return NotFound();
            }
            ViewData["GuestListId"] = new SelectList(_context.guestLists, "Id", "Id", guest.GuestListId);
            //ViewData["NotesId"] = new SelectList(_context.notes, "Id", "Id", guest.NotesId);
            return View(guest);
        }

        // POST: User/Guests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Email,AllowedPusOne,GuestListId,RSVP,PlusOne,PlusOneName,PlusOneSurname,NotesId")] Guest guest)
        {
            if (id != guest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuestExists(guest.Id))
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
            ViewData["GuestListId"] = new SelectList(_context.guestLists, "Id", "Id", guest.GuestListId);
            //ViewData["NotesId"] = new SelectList(_context.notes, "Id", "Id", guest.NotesId);
            return View(guest);
        }

        // GET: User/Guests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.guests
                .Include(g => g.GuestList)
                //.Include(g => g.Notes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guest == null)
            {
                return NotFound();
            }

            return View(guest);
        }

        // POST: User/Guests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guest = await _context.guests.FindAsync(id);
            _context.guests.Remove(guest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuestExists(int id)
        {
            return _context.guests.Any(e => e.Id == id);
        }
    }
}
