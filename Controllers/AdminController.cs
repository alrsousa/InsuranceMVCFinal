
/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insurees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurees);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                //                db.Entry(insurees).State = EntityState.Modified;
                //                db.SaveChanges();
                //                return RedirectToAction("Index");
                if (ModelState.IsValid)
                {
                    var today = DateTime.Today;
                    int userAge = today.Year - insurees.DateOfBirth.Year;
                    double quote = 50;
                    if (userAge < 19)
                    {
                        quote = quote + 100;
                    }
                    else if (userAge > 18 && userAge < 26)
                    {
                        quote = quote + 50;
                    }
                    else if (userAge > 25)
                    {
                        quote = quote + 25;
                    }

                    if (insurees.CarYear < 2000 || insurees.CarYear > 2015)
                    {
                        quote = quote + 25;
                    }
                    if (insurees.CarMake == "Porsche")
                    {
                        quote = quote + 25;
                    }
                    if (insurees.CarModel == "911 Carrera")
                    {
                        quote = quote + 25;
                    }

                    double speedingTicketCost = insurees.SpeedingTickets * 10;
                    quote = quote + speedingTicketCost;

                    if (insurees.DUI == true)
                    {
                        quote = quote + (quote * 0.25);
                    }
                    if (insurees.CoverageType == true)
                    {
                        quote = quote + (quote * 0.50);
                    }
                    Convert.ToDecimal(quote);
                    insurees.Quote = (decimal)quote;
                    db.Entry(insurees).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            return View(insurees);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees insurees = db.Insurees.Find(id);
            db.Insurees.Remove(insurees);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
*/