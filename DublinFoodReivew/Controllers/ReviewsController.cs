using DublinFoodReivew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DublinFoodReivew.Controllers
{
    [ChildActionOnly]
    public class ReviewsController : Controller
    {
        public ActionResult BestReview()
        {
            var bestReview = from r in _reviews
                             orderby r.Rating descending
                             select r;

            return PartialView("_Review", bestReview.First());
        }

        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.District
                select r; 

            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<RestaurantReviewModel> _reviews = new List<RestaurantReviewModel>
        {
            new RestaurantReviewModel
            {
                Id = 1,
                Name = "The Oak",
                District = "Town",
                Cuisine = "Bistro",
                Rating = 6,
            },
             new RestaurantReviewModel
            {
                Id = 2,
                Name = "Siam Thai",
                District = "Portmarnock",
                Cuisine = "Thai",
                Rating = 7,
            },
              new RestaurantReviewModel
            {
                Id = 3,
                Name = "Little Ass Burritos",
                District = "Dawson Street",
                Cuisine = "Mexican",
                Rating = 10,
            }
        };
    }
}
