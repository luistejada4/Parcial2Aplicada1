using Parcial2Aplicada1.DAL;
using Parcial2Aplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.BLL
{
    public class EmpleadosBLL
    {
        public static Empleado empleadoReturn = null;

        public static bool Guardar(Empleado empleado)
        {
            using (var db = new Repositorio<Empleado>())
            {
                if(Buscar(empleado.EmpleadoId) == false)
                {
                    if (db.Guardar(empleado) != null)
                    {
                        empleadoReturn = empleado;
                        return true;
                    }
                    else
                    {
                        empleadoReturn = null;
                        return false;
                    }
                }
                else
                {
                    db.Modificar(empleado);
                    return true;
                }
               
            }
        }
        public static bool Buscar(int id)
        {
            using (var db = new Repositorio<Empleado>())
            {
                if((empleadoReturn = db.Buscar(e => e.EmpleadoId == id)) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool  Eliminar(int id)
        {
            using (var db = new Repositorio<Empleado>())
            {
                if(Buscar(id))
                {
                    if(db.Eliminar(empleadoReturn))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    empleadoReturn = null;
                    return false;
                }
                
            }
        }
        public static List<Empleado> GetList()
        {
            using (var db = new Repositorio<Empleado>())
            {
                return db.GetList();
            }
        }
        public static List<Empleado> GetListWhere(Expression<Func<Empleado, bool>> criterio)
        {
            using (var db = new Repositorio<Empleado>())
            {
                return db.GetListWhere(criterio);
            }
        }
    }
}
