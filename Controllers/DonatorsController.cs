using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BloodDriveDonation.Data;
using BloodDriveDonation.Models;

namespace BloodDriveDonation.Controllers
{
    public class DonatorsController : Controller
    {
        private readonly BloodDriveContext _context;

        public DonatorsController(BloodDriveContext context)
        {
            _context = context;
        }

        // GET: Donators
        public async Task<IActionResult> Index()
        {
            return View(await _context.Donators.ToListAsync());
        }

        // GET: Donators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donator = await _context.Donators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (donator == null)
            {
                return NotFound();
            }

            return View(donator);
        }

        // GET: Donators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Donators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Sex,Email,PhoneNumber,State")] Donator donator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donator);
        }

        // GET: Donators/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donator = await _context.Donators.FindAsync(id);
            if (donator == null)
            {
                return NotFound();
            }
            return View(donator);
        }

        // POST: Donators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Sex,Email,PhoneNumber,State")] Donator donator)
        {
            if (id != donator.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonatorExists(donator.ID))
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
            return View(donator);
        }

        // GET: Donators/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donator = await _context.Donators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (donator == null)
            {
                return NotFound();
            }

            return View(donator);
        }

        // POST: Donators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donator = await _context.Donators.FindAsync(id);
            _context.Donators.Remove(donator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonatorExists(int id)
        {
            return _context.Donators.Any(e => e.ID == id);
        }
    }
}
