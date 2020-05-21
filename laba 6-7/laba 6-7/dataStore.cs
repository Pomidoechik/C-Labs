using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_7
{



  class DataStore : DbContext
  {
    public DataStore()
    : base("DB")
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Market> Markets { get; set; }

  }

}
