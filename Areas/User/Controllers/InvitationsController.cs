using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WeddingAnniversary.Areas.User.Models;
using WeddingAnniversary.Data;

namespace WeddingAnniversary.Areas.User.Controllers
{
    [Area("User")]
    public class InvitationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvitationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User/Invitations
        [Route("User/Invitations")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Invitation> invitations = await _context.invitations.ToListAsync();
            return View(invitations);
        }

        [HttpGet("{UserName}")]
        [Route("User/Invitations/ViewSingle/{UserName}")]
        [Route("User/Invitations/ViewSingle")]
        public async Task<IActionResult> ViewSingle(string UserName)
        {
            IEnumerable<Invitation> invitations = await _context.invitations.Where(i => i.OwnerEmail == UserName).ToListAsync();
            return View(invitations);
        }

        [HttpGet("{ID}")]
        [Route("User/Invitations/ViewInvitation/{ID}")]
        [Route("User/Invitations/ViewInvitation")]
        public IActionResult ViewInvitation(int ID)
        {
            Invitation invitation = _context.invitations.Where(i => i.Id == ID).FirstOrDefault();
            return View(invitation);
        }

        [HttpGet("{ID}")]
        [Route("User/Invitations/ViewRSVP/{ID}")]
        [Route("User/Invitations/ViewRSVP")]
        public async Task<IActionResult> ViewRSVP(int ID)
        {
            Invitation invitation = _context.invitations.Where(i => i.Id == ID).FirstOrDefault();

            GuestList gList = new GuestList();

            if (invitation.GuestListId == null)
            {
                _context.guestLists.Add(gList);
                await _context.SaveChangesAsync();
                invitation.GuestListId = gList.Id;
                await _context.SaveChangesAsync();
            }
            if (invitation.GuestListId != null)
            {
                Guest g = new Guest();
                g.GuestListId = Convert.ToInt32(invitation.GuestListId);
                return View(g);
            } else
            {
                return NotFound();
            }
        }

        // GET: User/Invitations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invitation = await _context.invitations
                .Include(i => i.Schedule)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invitation == null)
            {
                return NotFound();
            }

            return View(invitation);
        }

        // GET: User/Invitations/Create
        [Route("User/Invitations/Create")]
        public IActionResult Create()
        {
            ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id");
            return View();
        }

        // POST: User/Invitations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/CreateJson")]
        public async Task<IActionResult> CreateJson()//[FromBody] Invite invitation)
        {
            var reader = new StreamReader(
            Request.Body,
            encoding: Encoding.UTF8,
            detectEncodingFromByteOrderMarks: false
            );
            var bodyString = await reader.ReadToEndAsync();

            var invitation = JsonConvert.DeserializeObject<Invite>(bodyString);


            //string shit = invitation.InvitationIntro;
            Invitation inv = new Invitation();
            inv.InvitationIntro = invitation.InvitationIntro;
            inv.OurStory = invitation.OurStory;
            inv.OwnerEmail = invitation.OwnerEmail;
            inv.RSVPDate = invitation.RSVPDate;
            inv.ScheduleId = invitation.ScheduleId;
            inv.Venue = invitation.Venue;
            inv.VenueLocation = invitation.VenueLocation;
            inv.VenueWebsite = invitation.VenueWebsite;
            inv.WeddingDate = invitation.WeddingDate;
            inv.WeddingName = invitation.WeddingName;
            inv.NotesId = invitation.NotesId == -1 ? null : _context.notes.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            //invitation.Id = _context.invitations.FirstOrDefault() == null ? 1 :  _context.invitations.OrderByDescending(i => i.Id).FirstOrDefault().Id + 1;
            if (ModelState.IsValid)
            {
                _context.Add(inv);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return Json(new { success = true, message = "Create Successful" });
            }
            else
            {
                string errors = "";
                int idx = 1;
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errors += idx++ + ": " + error;
                    }
                }
                return Json(new { success = false, message = "Error while creating: " + errors });
            }
            //ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", invitation.ScheduleId);
            //return View(invitation);
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/UpdateJson")]
        public async Task<IActionResult> UpdateJson()
        {
            var reader = new StreamReader(
            Request.Body,
            encoding: Encoding.UTF8,
            detectEncodingFromByteOrderMarks: false
            );
            var bodyString = await reader.ReadToEndAsync();

            var invitation = JsonConvert.DeserializeObject<Invite>(bodyString);


            //string shit = invitation.InvitationIntro;
            Invitation inv = new Invitation();
            inv.Id = invitation.Id;
            inv.InvitationIntro = invitation.InvitationIntro;
            inv.OurStory = invitation.OurStory;
            inv.OwnerEmail = invitation.OwnerEmail;
            inv.RSVPDate = invitation.RSVPDate;
            inv.ScheduleId = invitation.ScheduleId;
            inv.Venue = invitation.Venue;
            inv.VenueLocation = invitation.VenueLocation;
            inv.VenueWebsite = invitation.VenueWebsite;
            inv.WeddingDate = invitation.WeddingDate;
            inv.WeddingName = invitation.WeddingName;
            inv.NotesId = invitation.NotesId == -1 ? null : _context.notes.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            //invitation.Id = _context.invitations.FirstOrDefault() == null ? 1 :  _context.invitations.OrderByDescending(i => i.Id).FirstOrDefault().Id + 1;
            if (ModelState.IsValid)
            {
                _context.Update(inv);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return Json(new { success = true, message = "Create Successful" });
            }
            else
            {
                string errors = "";
                int idx = 1;
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errors += idx++ + ": " + error;
                    }
                }
                return Json(new { success = false, message = "Error while creating: " + errors });
            }
            //ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", invitation.ScheduleId);
            //return View(invitation);
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/NotesJson")]
        public async Task<IActionResult> NotesJson()
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();

                IEnumerable<NoteItem> noteItems = JsonConvert.DeserializeObject<IEnumerable<NoteItem>>(bodyString);

                Notes ns = new Notes();
                _context.notes.Add(ns);
                await _context.SaveChangesAsync();
                int ID = ns.Id;

                foreach (NoteItem noteItem in noteItems)
                {
                    noteItem.NotesId = ID;
                    if (_context.noteItems.Where(n => n.NotesId == ID && n.NoteValue == noteItem.NoteValue).Count() <= 0)
                    {
                        _context.Add(noteItem);
                        await _context.SaveChangesAsync();
                    }
                }

                return Json(new { success = true, message = ID.ToString() });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/UpdateNotesJson")]
        public async Task<IActionResult> UpdateNotesJson()
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();

                NoteCollector collector = JsonConvert.DeserializeObject<NoteCollector>(bodyString);

                Notes ns = new Notes();
                if (_context.invitations.Where(i => i.Id == collector.Id).FirstOrDefault().NotesId == null)
                {
                    _context.notes.Add(ns);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    ns.Id = Convert.ToInt32(_context.invitations.Where(i => i.Id == collector.Id).FirstOrDefault().NotesId);
                }
                int ID = ns.Id;

                foreach (NoteItem noteItem in collector.Notes)
                {
                    noteItem.NotesId = ID;
                    if (_context.noteItems.Where(n => n.NotesId == ID && n.NoteValue == noteItem.NoteValue).Count() <= 0)
                    {
                        _context.Add(noteItem);
                        await _context.SaveChangesAsync();
                    }
                }

                return Json(new { success = true, message = ID.ToString() });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/SchedulesJson")]
        public async Task<IActionResult> SchedulesJson()
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();

                IEnumerable<ScheduleItem> scheduleItems = JsonConvert.DeserializeObject<IEnumerable<ScheduleItem>>(bodyString);

                Schedule ns = new Schedule();
                _context.schedules.Add(ns);
                await _context.SaveChangesAsync();
                int ID = ns.Id;

                foreach (ScheduleItem scheduleItem in scheduleItems)
                {
                    scheduleItem.ScheduleId = ID;
                    _context.scheduleItems.Add(scheduleItem);
                }
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = ID.ToString() });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/NoteJson")]
        public async Task<IActionResult> NoteJson()
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();

                var noteItem = JsonConvert.DeserializeObject<NoteItem>(bodyString);

                var returnVal = _context.notes.Add(new Notes());

                noteItem.NotesId = Convert.ToInt32(returnVal.CurrentValues["Id"]);

                _context.Add(noteItem);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = noteItem.NotesId });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/NoteJson/{ID:int}")]
        public async Task<IActionResult> NoteJson(int ID)
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();

                var noteItem = JsonConvert.DeserializeObject<NoteItem>(bodyString);

                noteItem.NotesId = ID;

                _context.Add(noteItem);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = noteItem.NotesId });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("User/Invitations/ScheduleJson")]
        public async Task<IActionResult> ScheduleJson()
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();

                var scheduleItem = JsonConvert.DeserializeObject<ScheduleItem>(bodyString);

                var returnVal = _context.schedules.Add(new Schedule());

                scheduleItem.ScheduleId = Convert.ToInt32(returnVal.CurrentValues["Id"]);

                _context.Add(scheduleItem);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = scheduleItem.ScheduleId });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpPost]
        [Route("User/Invitations/CreateVal/{OwnerEmail}/{InvitationIntro}/{OurStory}/{Venue}/{VenueLocation}/{VenueWebsite}/{WeddingDate:DateTime}/{RSVPDate:DateTime}")]
        public async Task<IActionResult> CreateValues(string OwnerEmail, string InvitationIntro, string OurStory, string Venue,string VenueLocation, string VenueWebsite, DateTime WeddingDate, DateTime RSVPDate)
        {
            Invitation invitation = new Invitation();
            invitation.OwnerEmail = OwnerEmail;
            invitation.InvitationIntro = InvitationIntro;
            invitation.OurStory = OurStory;
            invitation.Venue = Venue;
            invitation.VenueLocation = VenueLocation;
            invitation.VenueWebsite = VenueWebsite;
            invitation.WeddingDate = WeddingDate;
            invitation.RSVPDate = RSVPDate;
            // TODO add WeddingName
            invitation.Id = _context.invitations.OrderByDescending(i => i.Id).FirstOrDefault().Id + 1;
            if (ModelState.IsValid)
            {
                _context.Add(invitation);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return Json(new { success = true, message = "Create Successful" });
            }
            else
            {
                return Json(new { success = false, message = "Error while creating" });
            }
            //ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", invitation.ScheduleId);
            //return View(invitation);
        }

        // GET: User/Invitations/Edit/5
        [HttpGet("{ID}")]
        [Route("User/Invitations/Edit/{ID}")]
        [Route("User/Invitations/Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invitation = await _context.invitations.FindAsync(id);
            if (invitation == null)
            {
                return NotFound();
            }
            ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", invitation.ScheduleId);
            return View(invitation);
        }

        // POST: User/Invitations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OwnerEmail,InvitationIntro,OurStory,ScheduleId,Venue,VenueLocation,VenueWebsite,WeddingDate,RSVPDate")] Invitation invitation)
        {
            if (id != invitation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invitation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvitationExists(invitation.Id))
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
            ViewData["ScheduleId"] = new SelectList(_context.schedules, "Id", "Id", invitation.ScheduleId);
            return View(invitation);
        }

        // GET: User/Invitations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invitation = await _context.invitations
                .Include(i => i.Schedule)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invitation == null)
            {
                return NotFound();
            }

            return View(invitation);
        }

        // POST: User/Invitations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invitation = await _context.invitations.FindAsync(id);
            _context.invitations.Remove(invitation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvitationExists(int id)
        {
            return _context.invitations.Any(e => e.Id == id);
        }

        [HttpPost("{ID}")]
        [Consumes("application/json")]
        [Route("User/Invitations/CreateRSVP/{ID:int}")]
        public async Task<IActionResult> CreateRSVP(int ID)
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();
                var jsonData = "{\"" + bodyString.Replace("&", "\",\"").Replace("=", "\":\"") + "\"}";
                Guest g = JsonConvert.DeserializeObject<Guest>(jsonData);
                
                _context.guests.Add(g);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = g.Id.ToString() });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpGet("{ID}")]
        [Route("User/Invitations/GetNoteList/{ID:int}")]
        [Route("User/Invitations/GetNoteList")]
        public IActionResult GetNoteList(int ID)
        {
            try
            {
                int nListId;
                if (_context.invitations.Where(i => i.Id == ID).FirstOrDefault().NotesId == null)
                {
                    return Json(new { success = false, message = -1 });
                }else
                {
                    nListId = Convert.ToInt32(_context.invitations.Where(i => i.Id == ID).FirstOrDefault().NotesId);
                    if (_context.noteItems.Where(g => g.NotesId == nListId).Count() <= 0) {
                        return Json(new { success = false, message = -1 });
                    }
                    string data = "";
                    foreach(NoteItem note in _context.noteItems.Where(g => g.NotesId == nListId))
                    {
                        data += note.NoteValue + "#%#";
                    }
                    data = data.Substring(0, data.Length - 3);
                    return Json(new { success = true, message = data });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpGet("{ID}")]
        [Route("User/Invitations/GetGuestInvitation/{ID:int}")]
        [Route("User/Invitations/GetGuestInvitation")]
        public IActionResult GetGuestInvitation(int ID)
        {
            try
            {
                int nListId;
                nListId = Convert.ToInt32(_context.invitations.Where(i => i.GuestListId == ID).FirstOrDefault().Id);

                return Json(new { success = true, message = nListId });
            
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "There was a problem finding the page" });
            }
        }

        [HttpGet("{ID}")]
        [Route("User/Invitations/DeleteGuest/{ID:int}")]
        [Route("User/Invitations/DeleteGuest")]
        public IActionResult DeleteGuest(int ID)
        {
            try
            {
                Guest guest = _context.guests.Where(g => g.Id == ID).FirstOrDefault();

                if (guest != null)
                {
                    _context.guests.Remove(guest);
                }

                return Json(new { success = true, message = ID });

            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "There was a problem finding the guest" });
            }
        }

        [HttpGet("{ID}")]
        [Route("User/Invitations/GetNotes/{ID:int}")]
        [Route("User/Invitations/GetNotes")]
        public IActionResult GetNotes(int ID)
        {
            try
            {
                int nListId;
                if (_context.invitations.Where(i => i.Id == ID).FirstOrDefault().NotesId == null)
                {
                    return Json(new { success = false, message = -1 });
                }else
                {
                    nListId = Convert.ToInt32(_context.invitations.Where(i => i.Id == ID).FirstOrDefault().NotesId);
                    if (_context.noteItems.Where(g => g.NotesId == nListId).Count() <= 0) {
                        return Json(new { success = false, message = -1 });
                    }
                    return Json(new { success = true, message = Json(_context.noteItems.Where(g => g.NotesId == nListId)) });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }

        [HttpGet("{ID}")]
        [Route("User/Invitations/GetRSVPs/{ID:int}")]
        [Route("User/Invitations/GetRSVPs")]
        public IActionResult GetRSVPs(int ID)
        {
            try
            {
                int gListId;
                if (_context.invitations.Where(i => i.Id == ID).FirstOrDefault().GuestListId == null)
                {
                    return Json(new { success = false, message = -1 });
                }else
                {
                    gListId = Convert.ToInt32(_context.invitations.Where(i => i.Id == ID).FirstOrDefault().GuestListId);
                    if (_context.guests.Where(g => g.GuestListId == gListId).Count() <= 0)
                    {
                        return Json(new { success = false, message = -1 });
                    }
                    return Json(new { success = true, message = Json(_context.guests.Where(g => g.GuestListId == gListId)) });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { success = false, message = -1 });
            }
        }


        [HttpPost]
        [Consumes("application/json")]
        [Route("/User/Invitations/UpdateInvitation")]
        public async Task<ReturnClass> UpdateInvitation()
        {
            try
            {
                var reader = new StreamReader(
                Request.Body,
                encoding: Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false
                );
                var bodyString = await reader.ReadToEndAsync();

                var invitation = JsonConvert.DeserializeObject<Invitation>(bodyString.Replace("\r", "").Replace("\n", ""));


                Invitation invite = await _context.invitations.FindAsync(invitation.Id);

                invite.InvitationIntro = invitation.InvitationIntro;
                invite.OurStory = invitation.OurStory;
                invite.OwnerEmail = invitation.OwnerEmail;
                invite.RSVPDate = invitation.RSVPDate;
                invite.ScheduleId = invitation.ScheduleId;
                invite.Venue = invitation.Venue;
                invite.VenueLocation = invitation.VenueLocation;
                invite.VenueWebsite = invitation.VenueWebsite;
                invite.WeddingDate = invitation.WeddingDate;
                invite.WeddingName = invitation.WeddingName;
                invite.NotesId = invitation.NotesId;

                _context.invitations.Update(invite);
                await _context.SaveChangesAsync();
                return new ReturnClass(true, "1");
            }
            catch (Exception ex)
            {
                return new ReturnClass(false, ex.Message);
            }
        }

        [HttpDelete]
        [Route("User/Invitations/DeleteInvitation/{id:int}/{user}")]
        public async Task<IActionResult> DeleteInvitation(int id, string user)
        {
            try
            {
                var guest = await _context.guests.FindAsync(id);
                _context.guests.Remove(guest);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = 1 });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("User/Invitations/EditInvitation/{id:int}/{user}")]
        public IActionResult EditInvitation(int id, string user)
        {
            try
            {
                var invite = _context.invitations.Where(x => x.Id == id).FirstOrDefault();

                if (user == invite.OwnerEmail)
                {
                    return Json(new { success = true, message = "Authorization accepted" });
                }
                else
                {
                    return Json(new { success = false, message = "Not authorized" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
