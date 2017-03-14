using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.Entidades
{
    public class TipoEmail
    {
        [Key]
        public int TipoEmailId { get; set; }
        public string Descripcion { get; set; }

        public TipoEmail()
        {

        }
        public TipoEmail(int tipoEmailId, string descripcion)
        {
            this.TipoEmailId = tipoEmailId;
            this.Descripcion = descripcion;
        }
    }
}
