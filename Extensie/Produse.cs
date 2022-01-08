namespace Extensie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produse")]
    public partial class Produse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Idprodus { get; set; }

        [StringLength(50)]
        public string Culoare { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public int? Datacumparari { get; set; }
    }
}
