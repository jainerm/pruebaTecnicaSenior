using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace pruebaParaPrimeStone.Models
{
    [Table("estudiantes")]
    public class Estudiantes
    {
        [Key]
        public String estudiante_id { get; set; }
        [Required]
        [StringLength(30)]
        public String primer_nombre { get; set; }
        [Required]
        [StringLength(30)]
        public String segundo_nomgre { get; set; }
        [Required]
        [StringLength(50)]
        public String apellidos { get; set; }
        public DateTime fec_ingreso { get; set; }
        [Required]
        [StringLength(15)]
        public String telefono { get; set; }

    }
}