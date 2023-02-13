using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab5.Data;
using lab5.Models;

namespace lab5.Controllers
{
    public class Doctor_LabModelController : Controller
    {
        private readonly HospitalContext _context;

        public Doctor_LabModelController(HospitalContext context)
        {
            _context = context;
        }

        // GET: Doctor_LabModel
        public async Task<IActionResult> Index()
        {
            var hospitalContext = _context.Doctor_Lab.Include(d => d.Doctor).Include(d => d.Lab);
            return View(await hospitalContext.ToListAsync());
        }

        // GET: Doctor_LabModel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_LabModel = await _context.Doctor_Lab
                .Include(d => d.Doctor)
                .Include(d => d.Lab)
                .FirstOrDefaultAsync(m => m.LabId == id);
            if (doctor_LabModel == null)
            {
                return NotFound();
            }

            return View(doctor_LabModel);
        }

        // GET: Doctor_LabModel/Create
        public IActionResult Create()
        {
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name");
            ViewData["LabId"] = new SelectList(_context.Labs, "Id", "Address");
            return View();
        }

        // POST: Doctor_LabModel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorId,LabId")] Doctor_LabModel doctor_LabModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor_LabModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name", doctor_LabModel.DoctorId);
            ViewData["LabId"] = new SelectList(_context.Labs, "Id", "Address", doctor_LabModel.LabId);
            return View(doctor_LabModel);
        }

        // GET: Doctor_LabModel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_LabModel = await _context.Doctor_Lab.FindAsync(id);
            if (doctor_LabModel == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name", doctor_LabModel.DoctorId);
            ViewData["LabId"] = new SelectList(_context.Labs, "Id", "Address", doctor_LabModel.LabId);
            return View(doctor_LabModel);
        }

        // POST: Doctor_LabModel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorId,LabId")] Doctor_LabModel doctor_LabModel)
        {
            if (id != doctor_LabModel.LabId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor_LabModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doctor_LabModelExists(doctor_LabModel.LabId))
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
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name", doctor_LabModel.DoctorId);
            ViewData["LabId"] = new SelectList(_context.Labs, "Id", "Address", doctor_LabModel.LabId);
            return View(doctor_LabModel);
        }

        // GET: Doctor_LabModel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_LabModel = await _context.Doctor_Lab
                .Include(d => d.Doctor)
                .Include(d => d.Lab)
                .FirstOrDefaultAsync(m => m.LabId == id);
            if (doctor_LabModel == null)
            {
                return NotFound();
            }

            return View(doctor_LabModel);
        }

        // POST: Doctor_LabModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor_LabModel = await _context.Doctor_Lab.FindAsync(id);
            _context.Doctor_Lab.Remove(doctor_LabModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Doctor_LabModelExists(int id)
        {
            return _context.Doctor_Lab.Any(e => e.LabId == id);
        }
    }
}
