using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestPrinterBilling.Data;
using BestPrinterBilling.Models;

namespace BestPrinterBilling.Controllers
{
    public class Customers : BaseController
    {
        private readonly bestprinterbillingdbContext _context;

        public Customers(bestprinterbillingdbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            AddPageHeader("Customers", "");
            return View(await _context.TblUsers.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            AddPageHeader("Customer Information", "");
            if (id == null)
            {
                return NotFound();
            }

            var tblUsers = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (tblUsers == null)
            {
                return NotFound();
            }

            return View(tblUsers);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            AddPageHeader("Add new customer", "");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Username,Password,ContactName,Email,Phone,Company,Isadmin")] TblUsers tblUsers)
        {
            AddPageHeader("Add new customer", "");
            if (ModelState.IsValid)
            {
                _context.Add(tblUsers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblUsers);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            AddPageHeader("Edit customer information", "");
            if (id == null)
            {
                return NotFound();
            }

            var tblUsers = await _context.TblUsers.FindAsync(id);
            if (tblUsers == null)
            {
                return NotFound();
            }
            return View(tblUsers);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Username,Password,ContactName,Email,Phone,Company,Isadmin")] TblUsers tblUsers)
        {
            AddPageHeader("Edit customer information", "");
            if (id != tblUsers.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblUsers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblUsersExists(tblUsers.UserId))
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
            return View(tblUsers);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            AddPageHeader("Delete customer", " ");
            if (id == null)
            {
                return NotFound();
            }

            var tblUsers = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (tblUsers == null)
            {
                return NotFound();
            }

            return View(tblUsers);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            AddPageHeader("Edit customer information", "");
            var tblUsers = await _context.TblUsers.FindAsync(id);
            _context.TblUsers.Remove(tblUsers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblUsersExists(int id)
        {
            return _context.TblUsers.Any(e => e.UserId == id);
        }
    }
}
