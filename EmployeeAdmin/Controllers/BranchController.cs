﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeModel.Models;
using EmployeeAdmin.Models;

namespace EmployeeAdmin.Controllers
{
    [Authorize]
    public class BranchController : Controller
    {
        private EmployeeAdminContext db = new EmployeeAdminContext();
        [AllowAnonymous]
        public ActionResult AllBranch()
        {
            var branch = db.Branches.OrderBy(b => b.location);
            return Json(branch, JsonRequestBehavior.AllowGet);
        }
        // GET: /Branch/
        public ActionResult Index()
        {
            var branches = db.Branches.Include(b => b.branchOrg);
            return View(branches.ToList());
        }

        // GET: /Branch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Branch branch = db.Branches.Find(id);
            if (branch == null)
            {
                return HttpNotFound();
            }
            return View(branch);
        }

        // GET: /Branch/Create
        public ActionResult Create()
        {
            ViewBag.OrgId = new SelectList(db.Organizations, "orgId", "orgName");
            return View();
        }

        // POST: /Branch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="branchId,branchPhone,location,OrgId")] Branch branch)
        {
            if (ModelState.IsValid)
            {
                db.Branches.Add(branch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrgId = new SelectList(db.Organizations, "orgId", "orgName", branch.OrgId);
            return View(branch);
        }

        // GET: /Branch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Branch branch = db.Branches.Find(id);
            if (branch == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrgId = new SelectList(db.Organizations, "orgId", "orgName", branch.OrgId);
            return View(branch);
        }

        // POST: /Branch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="branchId,branchPhone,location,OrgId")] Branch branch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(branch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrgId = new SelectList(db.Organizations, "orgId", "orgName", branch.OrgId);
            return View(branch);
        }

        // GET: /Branch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Branch branch = db.Branches.Find(id);
            if (branch == null)
            {
                return HttpNotFound();
            }
            return View(branch);
        }

        // POST: /Branch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Branch branch = db.Branches.Find(id);
            db.Branches.Remove(branch);
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
