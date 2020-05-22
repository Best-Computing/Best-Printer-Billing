using BestPrinterBilling.Common.Attributes;
using BestPrinterBilling.Data;
using BestPrinterBilling.Models;
using BestPrinterBilling.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BestPrinterBilling.Controllers
{
    [Authorize]

    public class Machines : BaseController
    {
   
        private readonly bestprinterbillingdbContext _context;
        private readonly TblMachine meterreadsdata;

        public Machines(bestprinterbillingdbContext context)
        {
            _context = context;
        }

        /*  public ActionResult MachineClientViewModel()
           {

               MachineClientViewModel machineClientVM = new MachineClientViewModel();
               machineClientVM.allMachines = _context
           }
         */
        // GET: Machines
        public IActionResult Index()
        {
            AddPageHeader("Meter Reads", "");
            return View();
        }

        // GET: Machines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            AddPageHeader("Meter Reads Information", "");
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

        // GET: Machines/Create
        public IActionResult Create()
        {
            AddPageHeader("Add new meter reads entry", "");
           // MachineClientViewModel machineClientVM = new MachineClientViewModel();
                  
            return View();
        }


        // Create view model . TblUsers,TblLocation,TblUsersMachine
        /*
        [HttpGet]
        public async Task<IActionResult> Create([Bind("MachineId,Serialnum,Devicemodel,UserId,PriceBw,PriceClr,PriceClrlrg,PrevRdsBw,PrevRdsClr,PrevRdsClrlrg,CurRdsBw,CurRdsClr,CurRdsClrlrg,QtyBw,QtyClr,QtyClrlrg,PrevInvoiceId,PrevInvoiceTotal,CurInvoiceId,CurInvoiceTotal,Status,ContractStart,ContractEnd,CollectionMethod,Location,MinCharge,IsActive,PrintCountBw,PrintCountColor,PrintCountLarge")] TblMachine tblMachine)


        {
            ViewBag.LocationName = new SelectList(_context.TblLocation, "LocationId", "LocationName");
            if (ModelState.IsValid)
            {
                _context.Add(tblMachine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblMachine);
        }
            
            if (ModelState.IsValid)
            {
                meterreadsdata.Location = model.TblLocation.LocationName;
                meterreadsdata.Customer = model.TblUsers.Company;
                meterreadsdata.ContactPerson = model.TblUsers.ContactName;
               
                meterreadsdata.Devicemodel = model.TblUsersmachine.Model;
                meterreadsdata.Serialnum = model.TblUsersmachine.Serial;
                meterreadsdata.Title = model.TblUsersmachine.Description;
                _context.Add(meterreadsdata);
                _context.SaveChangesAsync();

            }
            return RedirectToAction("Index");
        }
            // POST: Machines/Create
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

            */
           [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("MachineId,Serialnum,Devicemodel,UserId,PriceBw,PriceClr,PriceClrlrg,PrevRdsBw,PrevRdsClr,PrevRdsClrlrg,CurRdsBw,CurRdsClr,CurRdsClrlrg,QtyBw,QtyClr,QtyClrlrg,PrevInvoiceId,PrevInvoiceTotal,CurInvoiceId,CurInvoiceTotal,Status,ContractStart,ContractEnd,CollectionMethod,Location,MinCharge,IsActive,PrintCountBw,PrintCountColor,PrintCountLarge")] TblMachine tblMachine)
            {



                AddPageHeader("Add new meter reads entry", "");

                if (ModelState.IsValid)
                {
                    _context.Add(tblMachine);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(tblMachine);
            }

            // GET: Machines/Edit/5
            public async Task<IActionResult> Edit(int? id)
        {
            AddPageHeader("Edit meter reads entry", "");
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
        /*
        [HttpPost]
        public ActionResult Edit(MachineClientViewModel model)

        {
            if (ModelState.IsValid)
            {
                _context.Entry(model).State = EntityState.Modified;
                _context.Entry(model.TblLocation.LocationName).State = EntityState.Modified;
                _context.Entry(model.TblUsers.Company).State = EntityState.Modified;
                _context.Entry(model.TblUsersmachine.Model).State = EntityState.Modified;
                _context.Entry(model.TblUsersmachine.Serial).State = EntityState.Modified;
                _context.Entry(model.TblUsersmachine.Description).State = EntityState.Modified;

                _context.SaveChangesAsync();
                

            }
            return View();
        }
        */
        // POST: Machines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /* [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Edit(int id, [Bind("MachineId,Serialnum,Devicemodel,UserId,PriceBw,PriceClr,PriceClrlrg,PrevRdsBw,PrevRdsClr,PrevRdsClrlrg,CurRdsBw,CurRdsClr,CurRdsClrlrg,QtyBw,QtyClr,QtyClrlrg,PrevInvoiceId,PrevInvoiceTotal,CurInvoiceId,CurInvoiceTotal,Status,ContractStart,ContractEnd,CollectionMethod,Location,MinCharge,IsActive,PrintCountBw,PrintCountColor,PrintCountLarge")] TblMachine tblMachine)
         {
             AddPageHeader("Edit meter reads entry", "");
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
         */
        // GET: Machines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            AddPageHeader("Delete meter reads entry", "");
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

        // POST: Machines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            AddPageHeader("Deleted meter reads entry", "");
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
