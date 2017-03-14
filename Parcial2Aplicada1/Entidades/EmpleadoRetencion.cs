using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.Entidades
{
    public class EmpleadoRetencion
    {
        [Key]
        public int EmpleadoRetencionId { get; set; }
        public int EmpleadoId { get; set; }
        public int RetencionId { get; set; }
    }
}
