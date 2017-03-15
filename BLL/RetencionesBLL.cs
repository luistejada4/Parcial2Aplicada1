using Parcial2Aplicada1.DAL;
using Parcial2Aplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.BLL
{
    public class RetencionesBLL
    {
        public static Retencion retencionReturn = null;

        public static bool Guardar(Retencion retencion)
        {
            using (var db = new Repositorio<Retencion>())
            {
                if (Buscar(retencion.RetencionId) == false)
                {
                    if (db.Guardar(retencion) != null)
                    {
                        retencionReturn = retencion;
                        return true;
                    }
                    else
                    {
                        retencionReturn = null;
                        return false;
                    }
                }
                else
                {
                    db.Modificar(retencion);
                    return true;
                }

            }
        }
        public static bool Buscar(int id)
        {
            using (var db = new Repositorio<Retencion>())
            {
                if ((retencionReturn = db.Buscar(e => e.RetencionId == id)) != null)
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
            using (var db = new Repositorio<Retencion>())
            {
                if (Buscar(id))
                {
                    if (db.Eliminar(retencionReturn))
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
                    retencionReturn = null;
                    return false;
                }

            }
        }
        public static List<Retencion> GetList()
        {
            using (var db = new Repositorio<Retencion>())
            {
                return db.GetList();
            }
        }
    }
}
