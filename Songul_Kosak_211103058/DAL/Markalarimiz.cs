namespace Songul_Kosak_211103058.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Markalarimiz")]
    public partial class Markalarimiz
    {
        public int MarkalarimizId { get; set; }

        [StringLength(500)]
        public string MarkaResimYolu { get; set; }

        [StringLength(50)]
        public string Sira { get; set; }

    }
}
