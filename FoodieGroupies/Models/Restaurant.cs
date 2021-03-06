﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Cuisine")]
        public int CuisineID { get; set; }
        public virtual Cuisine Cuisine { get; set; }
    }
}