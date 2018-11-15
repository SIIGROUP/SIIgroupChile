using Interno.Common.Models;
using SiiGroupChileCross.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiiGroupChileCross.Domain.Models
{
  public  class DataContext : DbContext
    {
        public DataContext() : base ("DefaultConnection")
        {

        }

        public DbSet<Noticias> Noticias { get; set; }
    }
}
