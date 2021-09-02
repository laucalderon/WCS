
using System;
using System.ComponentModel.DataAnnotations;

namespace MODELOS
{
    public class Solicitud: BaseEntidad
    {
        [Required]
        [StringLength(10, ErrorMessage = "El número de identificación debe tener una longitud de 10")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El campo Nombre debe tener una longitud de 20")]
        [RegularExpression("(^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$)", ErrorMessage = "Solo se permiten letras")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El campo Apellidos debe tener una longitud de 20")]
        [RegularExpression("(^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$)", ErrorMessage = "Solo se permiten letras")]
        public string Apellidos { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Campo edad inválido, solo puede introducir de 1 a 99")]
        public int Edad { get; set; }

        [Required]
        public Casa CasaSolicitada { get; set; }
    }
}
