using System;
using System.Data.Entity;
using System.Linq;
using TotalSynergy.Models;

namespace TotalSynergy.Data
{
    public class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
    }
}