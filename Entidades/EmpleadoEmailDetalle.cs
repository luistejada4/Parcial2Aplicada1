using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.Entidades
{
    public class EmpleadoEmailDetalle
    {
        string Correo;
        string Tipo;

        public EmpleadoEmailDetalle()
        {

        }
        public EmpleadoEmailDetalle(string correo, string tipo)
        {
            this.Correo = correo;
            this.Tipo = tipo;
        }
    }
}
