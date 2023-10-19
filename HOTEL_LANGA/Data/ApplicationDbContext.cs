using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HOTEL_LANGA.Data
{
    public class ApplicationDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ApplicationDbContext() : base("name=ApplicationDbContext")
        {
        }

        public System.Data.Entity.DbSet<HOTEL_LANGA.Models.Funcionarios> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<HOTEL_LANGA.Models.Departamentos> Departamentos { get; set; }

        public System.Data.Entity.DbSet<HOTEL_LANGA.Models.Cargos> Cargos { get; set; }
    }
}
