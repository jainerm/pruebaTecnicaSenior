using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace pruebaParaPrimeStone.Models
{
    [Table("cursos")]
    public class cursos
    {
        [Key]
        public int curso_id { get; set; }
        public String nom_curso { get; set; }
        public DateTime fec_curso { get; set; }
        public String direccion { get; set; }

    }
}