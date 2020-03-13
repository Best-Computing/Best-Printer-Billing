using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestPrinterBilling.Data;
using BestPrinterBilling.Models;
using Microsoft.AspNetCore.Authorization;
using BestPrinterBilling.Common.Attributes;

namespace BestPrinterBilling
{
    [Authorize]
   
    public class TblMachinesController : Controller
    {
        private readonly bestprinterbillingdbContext _context;

        public TblMachinesController(bestprinterbillingdbContext context)
        {
            _context = context;
        }

        internal void AddPageHeader(string pageHeader = "", string pageDescription = "")
        {
            ViewBag.PageHeader = Tuple.Create(pageHeader, pageDescription);
        }

        // GET: TblMachines
        public async Task<IActionResult> Index()
        {
            AddPageHeader("Data Entry", "");
            return View(await _context.TblMachine.ToListAsync());
        }

        // GET: TblMachines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMachine = await _context.TblMachine
                .FirstOrDefaultAsync(m => m.MachineId == id);
            if (tblMachine == null)
            {
                return NotFound();
            }

            return View(tblMachine);
        }

        // GET: TblMachines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblMachines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MachineId,Serialnum,Devicemodel,UserId,PriceBw,PriceClr,PriceClrlrg,PrevRdsBw,PrevRdsClr,PrevRdsClrlrg,CurRdsBw,CurRdsClr,CurRdsClrlrg,QtyBw,QtyClr,QtyClrlrg,PrevInvoiceId,PrevInvoiceTotal,CurInvoiceId,CurInvoiceTotal,Status,ContractStart,ContractEnd,CollectionMethod,Location,MinCharge,IsActive")] TblMachine tblMachine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblMachine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblMachine);
        }

        // GET: TblMachines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMachine = await _context.TblMachine.FindAsync(id);
            if (tblMachine == null)
            {
                return NotFound();
            }
            return View(tblMachine);
        }

        // POST: TblMachines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MachineId,Serialnum,Devicemodel,UserId,PriceBw,PriceClr,PriceClrlrg,PrevRdsBw,PrevRdsClr,PrevRdsClrlrg,CurRdsBw,CurRdsClr,CurRdsClrlrg,QtyBw,QtyClr,QtyClrlrg,PrevInvoiceId,PrevInvoiceTotal,CurInvoiceId,CurInvoiceTotal,Status,ContractStart,ContractEnd,CollectionMethod,Location,MinCharge,IsActive")] TblMachine tblMachine)
        {
            if (id != tblMachine.MachineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblMachine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblMachineExists(tblMachine.MachineId))
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
            return View(tblMachine);
        }

        // GET: TblMachines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMachine = await _context.TblMachine
                .FirstOrDefaultAsync(m => m.MachineId == id);
            if (tblMachine == null)
            {
                return NotFound();
            }

            return View(tblMachine);
        }

        // POST: TblMachines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblMachine = await _context.TblMachine.FindAsync(id);
            _context.TblMachine.Remove(tblMachine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblMachineExists(int id)
        {
            return _context.TblMachine.Any(e => e.MachineId == id);
        }
    }
}
