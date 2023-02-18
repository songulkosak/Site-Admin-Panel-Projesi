namespace Songul_Kosak_211103058.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteBilgi")]
    public partial class SiteBilgi
    {
        public int SiteBilgiId { get; set; }

        [StringLength(500)]
        public string LogoYolu { get; set; }

        [StringLength(500)]
        public string FirmaAd { get; set; }

        [StringLength(500)]
        public string AltSabitYazi { get; set; }

        [StringLength(500)]
        public string SosyalMedya { get; set; }
    }
}
