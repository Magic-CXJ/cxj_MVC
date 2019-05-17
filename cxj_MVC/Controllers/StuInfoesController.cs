using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cxj_MVC.Models;

namespace cxj_MVC.Controllers
{
    public class StuInfoesController : Controller
    {
        private MyDb db = new MyDb();

        // GET: StuInfoes
        public ActionResult Index()
        {
            return View(db.StuInfoes.ToList());
        }

        // GET: StuInfoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StuInfo stuInfo = db.StuInfoes.Find(id);
            if (stuInfo == null)
            {
                return HttpNotFound();
            }
            return View(stuInfo);
        }

        // GET: StuInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StuInfoes/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Xueshengxuehao,Xueshengxingming,Xueshengxingbie")] StuInfo stuInfo)
        {
            if (ModelState.IsValid)
            {
                db.StuInfoes.Add(stuInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stuInfo);
        }

        // GET: StuInfoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StuInfo stuInfo = db.StuInfoes.Find(id);
            if (stuInfo == null)
            {
                return HttpNotFound();
            }
            return View(stuInfo);
        }

        // POST: StuInfoes/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Xueshengxuehao,Xueshengxingming,Xueshengxingbie")] StuInfo stuInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stuInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stuInfo);
        }

        // GET: StuInfoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StuInfo stuInfo = db.StuInfoes.Find(id);
            if (stuInfo == null)
            {
                return HttpNotFound();
            }
            return View(stuInfo);
        }

        // POST: StuInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            StuInfo stuInfo = db.StuInfoes.Find(id);
            db.StuInfoes.Remove(stuInfo);
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
