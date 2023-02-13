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
    public class Doctor_PatientModelController : Controller
    {
        private readonly HospitalContext _context;

        public Doctor_PatientModelController(HospitalContext context)
        {
            _context = context;
        }

        // GET: Doctor_PatientModel
        public async Task<IActionResult> Index()
        {
            var hospitalContext = _context.Doctor_Patients.Include(d => d.Doctor).Include(d => d.Patient);
            return View(await hospitalContext.ToListAsync());
        }

        // GET: Doctor_PatientModel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_PatientModel = await _context.Doctor_Patients
                .Include(d => d.Doctor)
                .Include(d => d.Patient)
                .FirstOrDefaultAsync(m => m.PatientId == id);
            if (doctor_PatientModel == null)
            {
                return NotFound();
            }

            return View(doctor_PatientModel);
        }

        // GET: Doctor_PatientModel/Create
        public IActionResult Create()
        {
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name");
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Disease");
            return View();
        }

        // POST: Doctor_PatientModel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorId,PatientId")] Doctor_PatientModel doctor_PatientModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor_PatientModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name", doctor_PatientModel.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Disease", doctor_PatientModel.PatientId);
            return View(doctor_PatientModel);
        }

        // GET: Doctor_PatientModel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_PatientModel = await _context.Doctor_Patients.FindAsync(id);
            if (doctor_PatientModel == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name", doctor_PatientModel.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Disease", doctor_PatientModel.PatientId);
            return View(doctor_PatientModel);
        }

        // POST: Doctor_PatientModel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorId,PatientId")] Doctor_PatientModel doctor_PatientModel)
        {
            if (id != doctor_PatientModel.PatientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor_PatientModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doctor_PatientModelExists(doctor_PatientModel.PatientId))
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
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Name", doctor_PatientModel.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Disease", doctor_PatientModel.PatientId);
            return View(doctor_PatientModel);
        }

        // GET: Doctor_PatientModel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_PatientModel = await _context.Doctor_Patients
                .Include(d => d.Doctor)
                .Include(d => d.Patient)
                .FirstOrDefaultAsync(m => m.PatientId == id);
            if (doctor_PatientModel == null)
            {
                return NotFound();
            }

            return View(doctor_PatientModel);
        }

        // POST: Doctor_PatientModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor_PatientModel = await _context.Doctor_Patients.FindAsync(id);
            _context.Doctor_Patients.Remove(doctor_PatientModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Doctor_PatientModelExists(int id)
        {
            return _context.Doctor_Patients.Any(e => e.PatientId == id);
        }
    }
}
