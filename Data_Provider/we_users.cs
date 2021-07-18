namespace Data_Provider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class we_users
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Uid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Pwd { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Fullname { get; set; }
    }
}
