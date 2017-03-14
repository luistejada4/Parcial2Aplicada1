using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Aplicada1.DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity: class {


        private Parcial2DB Context;

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }

        public Repositorio()
        {
            Context = new Parcial2DB();
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> criterio)
        {
            TEntity result = null;
            try
            {
                result = EntitySet.FirstOrDefault(criterio);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
                throw;
            }
            return result;
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
            }
        }

        public bool Eliminar(TEntity entity)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(entity);
                EntitySet.Remove(entity);
                Context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<TEntity> GetList()
        {
            List<TEntity> lista = null;
            try
            {
                lista = EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public List<TEntity> GetListWhere(Expression<Func<TEntity, bool>> criterio)
        {
            List<TEntity> lista;
            try
            {
                lista = EntitySet.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public TEntity Guardar(TEntity entity)
        {
            TEntity result = null;
            try
            {
                EntitySet.Add(entity);
                Context.SaveChanges();
                result = entity;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Modificar(TEntity entity)
        {
            bool result = false;

            try
            {
                EntitySet.Attach(entity);

                Context.Entry<TEntity>(entity).State = EntityState.Modified;
                Context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
