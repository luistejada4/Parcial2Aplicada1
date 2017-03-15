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
    public class EmpleadosRetencionesBLL
    {
        public static EmpleadoRetencion empleadoRetencionReturn = null;

        public static bool Guardar(EmpleadoRetencion empleadoRetencion)
        {
            using (var db = new Repositorio<EmpleadoRetencion>())
            {
                if (Buscar(empleadoRetencion.EmpleadoRetencionId) == false)
                {
                    if (db.Guardar(empleadoRetencion) != null)
                    {
                        empleadoRetencionReturn = empleadoRetencion;
                        return true;
                    }
                    else
                    {
                        empleadoRetencionReturn = null;
                        return false;
                    }
                }
                else
                {
                    db.Modificar(empleadoRetencion);
                    return true;
                }

            }
        }
        public static bool Buscar(int id)
        {
            using (var db = new Repositorio<EmpleadoRetencion>())
            {
                if ((empleadoRetencionReturn = db.Buscar(e => e.EmpleadoRetencionId == id)) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Eliminar(int id)
        {
            using (var db = new Repositorio<EmpleadoRetencion>())
            {
                if (Buscar(id))
                {
                    if (db.Eliminar(empleadoRetencionReturn))
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
                    empleadoRetencionReturn = null;
                    return false;
                }

            }
        }
        public static List<EmpleadoRetencion> GetList()
        {
            using (var db = new Repositorio<EmpleadoRetencion>())
            {
                return db.GetList();
            }
        }
        public static List<EmpleadoRetencion> GetListWhere(Expression<Func<EmpleadoRetencion, bool>> criterio)
        {
            using (var db = new Repositorio<EmpleadoRetencion>())
            {
                return db.GetListWhere(criterio);
            }
        }
    }
}
