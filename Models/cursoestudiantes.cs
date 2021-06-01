using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace pruebaParaPrimeStone.Models
{
    [Table("cursoestudiantes")]
    public class cursoestudiantes
    {
        [Key]
        public int Id_cursoestudiante { get; set; }
        public String estudiane_id { get; set; }
        public String curso_id { get; set; }

    }
}