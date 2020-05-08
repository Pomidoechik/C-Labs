using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAA2
{


 
    class DataStore : DbContext
    {
      public DataStore()
      : base("DbConnection")
      { }

      public DbSet<User> Users { get; set; }
    }
  
}
