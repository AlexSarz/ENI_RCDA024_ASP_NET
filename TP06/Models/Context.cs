using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP06.Models
{
    public class Context : DbContext
    {   
        public Context() : base("name=Context")
        {
        }
        public System.Data.Entity.DbSet<TP06_BO.Samourai> Samourais { get; set; }
        public System.Data.Entity.DbSet<TP06_BO.Arme> Armes { get; set; }
    }
}
