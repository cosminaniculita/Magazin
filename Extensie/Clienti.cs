namespace Extensie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clienti")]
    public partial class Clienti
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Idclient { get; set; }

        [StringLength(50)]
        public string Nume { get; set; }

        [StringLength(50)]
        public string Prenume { get; set; }

        [Column("Adresa mail", TypeName = "text")]
        public string Adresa_mail { get; set; }
    }
}
