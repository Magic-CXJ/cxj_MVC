using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cxj_MVC.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<cxj_MVC.Models.StuInfo> StuInfoes { get; set; }

    }
}