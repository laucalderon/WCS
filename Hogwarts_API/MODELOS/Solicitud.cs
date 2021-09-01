using System;
using System.ComponentModel.DataAnnotations;

namespace DATOS
{
    public class Solicitud
    {
        [Key]
        public int IdSolicitud { get; set; }

        [Required]
        [MaxLength(10)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string Identificacion { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression("(^[a-zA-Z]*$)", ErrorMessage = "Solo se permiten letras")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression("(^[a-zA-Z]*$)", ErrorMessage = "Solo se permiten letras")]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(2)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public int Edad { get; set; }

        [Required]
        public Casa CasaSolicitada { get; set; }
    }
}
