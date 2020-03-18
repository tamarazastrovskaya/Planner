using Planner.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Context
{
    class AppContext : DbContext
    {

        public DbSet<Category> categories { get; set; }
        public AppContext(string Dsn): base(Dsn) { }

    }
    

    
}
