using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFacu.WebAPi.Data.Entities
{
    public class Professional
    {
        public int Id { get; set; }
        [Required]
        public string NomApellProf { get; set; }
        [Required]
        public string Especialidad { get; set; }
        [Required]
        public int DniProf { get; set; }
        [Required]
        public string Nacionalidad { get; set; }

        public string Provincia { get; set; }
    }
}
