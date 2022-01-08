namespace Extensie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comenzi")]
    public partial class Comenzi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Idcomanda { get; set; }

        public int? Idprodus { get; set; }

        public int? Idclient { get; set; }

        [Column("Data comenzi")]
        public int? Data_comenzi { get; set; }
    }
}
