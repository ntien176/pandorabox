namespace DataProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PandoraTable")]
    public partial class PandoraTable
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Uid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Pwd { get; set; }
    }
}
