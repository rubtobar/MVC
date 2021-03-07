﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }
    }
}
