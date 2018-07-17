﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodieGroupies.Models
{
    public class Cuisine
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}