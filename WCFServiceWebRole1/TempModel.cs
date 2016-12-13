using System.Configuration;

namespace WCFServiceWebRole1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TempModel : DbContext
    {
        public TempModel()
            : base("name=TempModel")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Temp> Temps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
