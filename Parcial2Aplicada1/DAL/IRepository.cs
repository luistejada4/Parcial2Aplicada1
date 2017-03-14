using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Aplicada1.DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Guardar(TEntity entity);
        bool Eliminar(TEntity entity);
        bool Modificar(TEntity entity);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterio);
        List<TEntity> GetListWhere(Expression<Func<TEntity, bool>> criterio);
        List<TEntity> GetList();
    }
}
