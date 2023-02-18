namespace Songul_Kosak_211103058.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lens")]
    public partial class Lens
    {
        public int LensId { get; set; }

        [StringLength(500)]
        public string LensResimYolu { get; set; }

        [StringLength(500)]
        public string LensÜstYazi { get; set; }

        [StringLength(500)]
        public string ResimSira { get; set; }
    }
}
