using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;

namespace TP04.Models
{
    public class PizzaViewModel
    {
        public int? Id { get; set; }
        
        public Pizza Pizza { get; set; }
    }
}