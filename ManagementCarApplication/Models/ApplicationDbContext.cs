using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManagementCarApplication.Models 
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}