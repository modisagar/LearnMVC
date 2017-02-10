﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Customer
    {
        [Required]
        [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$")]
        [Key]
        public string CustomerCode { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="CustomerName can not be more than 10 characters.")]
        public string CustomerName { get; set; }
    }
}