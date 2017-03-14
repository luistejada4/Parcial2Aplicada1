using Parcial2Aplicada1.DAL;
using Parcial2Aplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.BLL
{
    public class EmpleadosEmailsBLL
    {
        public static EmpleadoEmail empleadoEmailReturn = null;

        public static bool Guardar(EmpleadoEmail empleadoEmail)
        {
            using (var db = new Repositorio<EmpleadoEmail>())
            {
                if (Buscar(empleadoEmail.EmpleadoEmailId) == false)
                {
                    if (db.Guardar(empleadoEmail) != null)
                    {
                        empleadoEmailReturn = empleadoEmail;
                        return true;
                    }
                    else
                    {
                        empleadoEmailReturn = null;
                        return false;
                    }
                }
                else
                {
                    db.Modificar(empleadoEmail);
                    return true;
                }

            }
        }
        public static bool Buscar(int id)
        {
            using (var db = new Repositorio<EmpleadoEmail>())
            {
                if ((empleadoEmailReturn = db.Buscar(e => e.EmpleadoEmailId == id)) != null)
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
            using (var db = new Repositorio<EmpleadoEmail>())
            {
                if (Buscar(id))
                {
                    if (db.Eliminar(empleadoEmailReturn))
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
                    empleadoEmailReturn = null;
                    return false;
                }

            }
        }
        public static List<EmpleadoEmail> GetList()
        {
            using (var db = new Repositorio<EmpleadoEmail>())
            {
                return db.GetList();
            }
        }
    }
}
