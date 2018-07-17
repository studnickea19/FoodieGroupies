using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodieGroupies.Models;

namespace FoodieGroupies.Controllers
{
    public class RestaurantReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RestaurantReviews
        public ActionResult Index()
        {
            var restaurantReview = db.RestaurantReview.Include(r => r.Restaurant).Include(r => r.Review);
            return View(restaurantReview.ToList());
        }

        // GET: RestaurantReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RestaurantReview restaurantReview = db.RestaurantReview.Find(id);
            if (restaurantReview == null)
            {
                return HttpNotFound();
            }
            return View(restaurantReview);
        }

        // GET: RestaurantReviews/Create
        public ActionResult Create()
        {
            ViewBag.RestaurantID = new SelectList(db.Restaurant, "ID", "Name");
            ViewBag.ReviewID = new SelectList(db.Review, "ID", "ID");
            return View();
        }

        // POST: RestaurantReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewID,RestaurantID")] RestaurantReview restaurantReview)
        {
            if (ModelState.IsValid)
            {
                db.RestaurantReview.Add(restaurantReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RestaurantID = new SelectList(db.Restaurant, "ID", "Name", restaurantReview.RestaurantID);
            ViewBag.ReviewID = new SelectList(db.Review, "ID", "ID", restaurantReview.ReviewID);
            return View(restaurantReview);
        }

        // GET: RestaurantReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RestaurantReview restaurantReview = db.RestaurantReview.Find(id);
            if (restaurantReview == null)
            {
                return HttpNotFound();
            }
            ViewBag.RestaurantID = new SelectList(db.Restaurant, "ID", "Name", restaurantReview.RestaurantID);
            ViewBag.ReviewID = new SelectList(db.Review, "ID", "ID", restaurantReview.ReviewID);
            return View(restaurantReview);
        }

        // POST: RestaurantReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewID,RestaurantID")] RestaurantReview restaurantReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurantReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RestaurantID = new SelectList(db.Restaurant, "ID", "Name", restaurantReview.RestaurantID);
            ViewBag.ReviewID = new SelectList(db.Review, "ID", "ID", restaurantReview.ReviewID);
            return View(restaurantReview);
        }

        // GET: RestaurantReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RestaurantReview restaurantReview = db.RestaurantReview.Find(id);
            if (restaurantReview == null)
            {
                return HttpNotFound();
            }
            return View(restaurantReview);
        }

        // POST: RestaurantReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RestaurantReview restaurantReview = db.RestaurantReview.Find(id);
            db.RestaurantReview.Remove(restaurantReview);
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
