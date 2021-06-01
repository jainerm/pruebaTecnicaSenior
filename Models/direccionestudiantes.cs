using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace pruebaParaPrimeStone.Models
{
    [Table("direccionestudiantes")] 
    public class direccionestudiantes
    {
        [Key]
        public int domisilio_id { get; set; }
        public String sector_zona { get; set; }
        public String barrio_localidad { get; set; }
        public String direccion { get; set; }
        public String estudiante_id { get; set; }
    }
}