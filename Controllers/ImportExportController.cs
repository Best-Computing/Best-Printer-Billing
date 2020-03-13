using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestPrinterBilling.Views
{
    public class ImportExportController : Controller
    {
        // GET: ImportExport
        public ActionResult Index()
        {
            return View();
        }

        // GET: ImportExport/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ImportExport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImportExport/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ImportExport/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ImportExport/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ImportExport/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ImportExport/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}