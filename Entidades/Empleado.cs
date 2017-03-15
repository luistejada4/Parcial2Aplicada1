using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.Entidades
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Sueldo { get; set; }

        public Empleado()
        {

        }

        public Empleado(int empleadoId, string nombre, DateTime fechaNacimiento, int sueldo)
        {
            this.EmpleadoId = empleadoId;
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;
            this.Sueldo = sueldo;
        }
    }
}
