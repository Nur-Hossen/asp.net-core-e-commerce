using System.Linq;
using System.Threading.Tasks;

namespace Entities.Declarations
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> CreateAsync(TEntity entity);

        Task Update(int id, TEntity entity);

        Task Delete(int id);
    }
}
