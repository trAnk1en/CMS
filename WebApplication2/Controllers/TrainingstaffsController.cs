using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TrainingstaffsController : Controller
    {
        private readonly CmsContext _context;

        public TrainingstaffsController(CmsContext context)
        {
            _context = context;
        }

        // GET: Trainingstaffs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trainningstaffs.ToListAsync());
        }

        // GET: Trainingstaffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingstaff = await _context.Trainningstaffs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trainingstaff == null)
            {
                return NotFound();
            }

            return View(trainingstaff);
        }

        // GET: Trainingstaffs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trainingstaffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Edu,Experience,Department,UserName,PassWord,ID")] Trainingstaff trainingstaff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainingstaff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainingstaff);
        }

        // GET: Trainingstaffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingstaff = await _context.Trainningstaffs.FindAsync(id);
            if (trainingstaff == null)
            {
                return NotFound();
            }
            return View(trainingstaff);
        }

        // POST: Trainingstaffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Edu,Experience,Department,UserName,PassWord,ID")] Trainingstaff trainingstaff)
        {
            if (id != trainingstaff.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainingstaff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingstaffExists(trainingstaff.ID))
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
            return View(trainingstaff);
        }

        // GET: Trainingstaffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingstaff = await _context.Trainningstaffs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trainingstaff == null)
            {
                return NotFound();
            }

            return View(trainingstaff);
        }

        // POST: Trainingstaffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainingstaff = await _context.Trainningstaffs.FindAsync(id);
            _context.Trainningstaffs.Remove(trainingstaff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainingstaffExists(int id)
        {
            return _context.Trainningstaffs.Any(e => e.ID == id);
        }
    }
}
