using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodieGroupies.Models
{
    public class RestaurantReview
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Review")]
        public int ReviewID { get; set; }
        public virtual Review Review { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("Restaurant")]
        public int RestaurantID { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}