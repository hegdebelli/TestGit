using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFramework
{
    class Context : DbContext
    {
        public Context() : base("MyLocalDB_Connections")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDBContext, SchoolDataLayer.Migrations.Configuration>("MyLocalDB_Connections"));
        }
        public DbSet<Student> Student_DbSet { get; set; }
    }
   
}
