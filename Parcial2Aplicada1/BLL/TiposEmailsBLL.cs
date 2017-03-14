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
    public class TiposEmailsBLL
    {
        public static TipoEmail tipoEmailReturn = null;

        public static bool Guardar(TipoEmail tipoEmail)
        {
            using (var db = new Repositorio<TipoEmail>())
            {
                if (Buscar(tipoEmail.TipoEmailId) == false)
                {
                    if (db.Guardar(tipoEmail) != null)
                    {
                        tipoEmailReturn = tipoEmail;
                        return true;
                    }
                    else
                    {
                        tipoEmailReturn = null;
                        return false;
                    }
                }
                else
                {
                    db.Modificar(tipoEmail);
                    return true;
                }

            }
        }
        public static bool Buscar(int id)
        {
            using (var db = new Repositorio<TipoEmail>())
            {
                if ((tipoEmailReturn = db.Buscar(e => e.TipoEmailId == id)) != null)
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
            using (var db = new Repositorio<TipoEmail>())
            {
                if (Buscar(id))
                {
                    if (db.Eliminar(tipoEmailReturn))
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
                    tipoEmailReturn = null;
                    return false;
                }

            }
        }
        public static List<TipoEmail> GetList()
        {
            using (var db = new Repositorio<TipoEmail>())
            {
                return db.GetList();
            }
        }
        public static List<TipoEmail> GetListWhere(Expression<Func<TipoEmail, bool>> criterio)
        {
            using (var db = new Repositorio<TipoEmail>())
            {
                return db.GetListWhere(criterio);
            }
        }
    }
}
