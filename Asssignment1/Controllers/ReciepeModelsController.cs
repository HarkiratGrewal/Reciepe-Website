using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asssignment1.Models;

namespace Asssignment1.Controllers
{
    public class ReciepeModelsController : Controller
    {
        private readonly ReciepesAllContext _context;

        public ReciepeModelsController(ReciepesAllContext context)
        {
            _context = context;
        }

        // GET: ReciepeModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReciepeModel.ToListAsync());
        }

        // GET: ReciepeModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reciepeModel = await _context.ReciepeModel
                .SingleOrDefaultAsync(m => m.Id == id);
            if (reciepeModel == null)
            {
                return NotFound();
            }

            return View(reciepeModel);
        }

        // GET: ReciepeModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReciepeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,reciepeName,reciepeIngredients,reciepeProcedure")] ReciepeModel reciepeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reciepeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reciepeModel);
        }

        // GET: ReciepeModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reciepeModel = await _context.ReciepeModel.SingleOrDefaultAsync(m => m.Id == id);
            if (reciepeModel == null)
            {
                return NotFound();
            }
            return View(reciepeModel);
        }

        // POST: ReciepeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,reciepeName,reciepeIngredients,reciepeProcedure")] ReciepeModel reciepeModel)
        {
            if (id != reciepeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reciepeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReciepeModelExists(reciepeModel.Id))
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
            return View(reciepeModel);
        }

        // GET: ReciepeModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reciepeModel = await _context.ReciepeModel
                .SingleOrDefaultAsync(m => m.Id == id);
            if (reciepeModel == null)
            {
                return NotFound();
            }

            return View(reciepeModel);
        }

        // POST: ReciepeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reciepeModel = await _context.ReciepeModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.ReciepeModel.Remove(reciepeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReciepeModelExists(int id)
        {
            return _context.ReciepeModel.Any(e => e.Id == id);
        }
    }
}
