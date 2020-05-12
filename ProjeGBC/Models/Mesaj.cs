namespace ProjeGBC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesaj")]
    public partial class Mesaj
    {
        public int MesajId { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [StringLength(500)]
        public string İcerik { get; set; }

        public DateTime? Tarih { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
