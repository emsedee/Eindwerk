﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eindwerk.Entities;

namespace eindwerk.Controllers
{
    public class InterventiesController : Controller
    {
        private readonly DatabaseEindWerkContext _context;

        public InterventiesController(DatabaseEindWerkContext context)
        {
            _context = context;
        }

        // GET: Interventies
        public async Task<IActionResult> Index()
        {
            var databaseEindWerkContext = _context.Interventies.Include(i => i.Bestel).Include(i => i.Personeels).Include(i => i.Prioriteit).Include(i => i.Toestel);
            return View(await databaseEindWerkContext.ToListAsync());
        }

        // GET: Interventies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interventies = await _context.Interventies
                .Include(i => i.Bestel)
                .Include(i => i.Personeels)
                .Include(i => i.Prioriteit)
                .Include(i => i.Toestel)
                .FirstOrDefaultAsync(m => m.InterventieId == id);
            if (interventies == null)
            {
                return NotFound();
            }

            return View(interventies);
        }

        // GET: Interventies/Create
        public IActionResult Create()
        {
            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId");
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "PersoneelsId");
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "PrioriteitId");
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "ToestelId");
            return View();
        }

        // POST: Interventies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterventieId,Complexiteit,Meldingsdatum,Omschrijving,Einddatum,Duur,Verwachtteoplossingstermijn,OmschrijvingOplossing,PersoneelsId,PrioriteitId,ToestelId,BestelId,SoortInterventie")] Interventies interventies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interventies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "PersoneelsId", interventies.PersoneelsId);
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "PrioriteitId", interventies.PrioriteitId);
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "ToestelId", interventies.ToestelId);
            return View(interventies);
        }

        // GET: Interventies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interventies = await _context.Interventies.FindAsync(id);
            if (interventies == null)
            {
                return NotFound();
            }
            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "PersoneelsId", interventies.PersoneelsId);
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "PrioriteitId", interventies.PrioriteitId);
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "ToestelId", interventies.ToestelId);
            return View(interventies);
        }

        // POST: Interventies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InterventieId,Complexiteit,Meldingsdatum,Omschrijving,Einddatum,Duur,Verwachtteoplossingstermijn,OmschrijvingOplossing,PersoneelsId,PrioriteitId,ToestelId,BestelId,SoortInterventie")] Interventies interventies)
        {
            if (id != interventies.InterventieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interventies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterventiesExists(interventies.InterventieId))
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
            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "PersoneelsId", interventies.PersoneelsId);
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "PrioriteitId", interventies.PrioriteitId);
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "ToestelId", interventies.ToestelId);
            return View(interventies);
        }

        // GET: Interventies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interventies = await _context.Interventies
                .Include(i => i.Bestel)
                .Include(i => i.Personeels)
                .Include(i => i.Prioriteit)
                .Include(i => i.Toestel)
                .FirstOrDefaultAsync(m => m.InterventieId == id);
            if (interventies == null)
            {
                return NotFound();
            }

            return View(interventies);
        }

        // POST: Interventies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interventies = await _context.Interventies.FindAsync(id);
            _context.Interventies.Remove(interventies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterventiesExists(int id)
        {
            return _context.Interventies.Any(e => e.InterventieId == id);
        }
    }
}