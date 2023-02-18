using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Songul_Kosak_211103058.DAL
{
    public partial class DatabaseModel : DbContext
    {
        public DatabaseModel()
            : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<Anasayfa> Anasayfa { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Lens> Lens { get; set; }
        public virtual DbSet<Markalarimiz> Markalarimiz { get; set; }
        public virtual DbSet<SiteBilgi> SiteBilgi { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
