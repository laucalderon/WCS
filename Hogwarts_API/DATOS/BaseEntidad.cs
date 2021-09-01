using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS
{
    public interface IBaseEntidad
    {
        public int Id { get; set; }
    }
    public abstract class BaseEntidad : IBaseEntidad
    {
        [Key]
        public int Id { get; set; }
    }
}
