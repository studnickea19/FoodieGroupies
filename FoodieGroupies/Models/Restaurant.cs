using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodieGroupies.Models
{
    public class Restaurant
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name="Cuisine Type")]
        public string Type { get; set; }
    }
}