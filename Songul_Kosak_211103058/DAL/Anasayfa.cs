namespace Songul_Kosak_211103058.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Anasayfa")]
    public partial class Anasayfa
    {
        public int AnasayfaId { get; set; }

        [StringLength(500)]
        public string UstResimYolu { get; set; }

        [StringLength(500)]
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string OrtaBaslik { get; set; }

        [StringLength(500)]
        public string AraResim { get; set; }
        [StringLength(500)]
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string BizKimizYazisi { get; set; }
        [StringLength(500)]
        public string BizKimizBaslik { get; set; }
        [StringLength(500)]
        public string ButonYazi { get; set; }
        public string AltResimYolu { get; set; }
        [StringLength(500)]
        public string AltResimBaslik { get; set; }
        [StringLength(500)]
        public string AltResimYazi { get; set; }


    }
}
