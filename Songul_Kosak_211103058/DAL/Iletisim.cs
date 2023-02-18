namespace Songul_Kosak_211103058.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Iletisim")]
    public partial class Iletisim
    {
        public int IletisimId { get; set; }

        [StringLength(500)]
        public string AdresBaslik { get; set; }

        [StringLength(500)]
        public string BaslikBilgi { get; set; }

        [StringLength(500)]
        public string BizeUlasinYazisi { get; set; }
        [StringLength(500)]
        public string AdresSatir1 { get; set; }
        [StringLength(500)]
        public string AdresSatir2 { get; set; }
        [StringLength(500)]
        public string AdresSatir3 { get; set; }
        [StringLength(500)]
        public string Tel1 { get; set; }
        [StringLength(500)]
        public string Tel2 { get; set; }

    }
}
