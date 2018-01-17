using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DublinFoodReivew.Models
{
    public class RestaurantReviewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public string Cuisine { get; set; }
        public int Rating { get; set; }
    }
}