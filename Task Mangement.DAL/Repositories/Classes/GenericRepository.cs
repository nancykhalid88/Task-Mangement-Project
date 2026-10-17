using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Mangement.DAL.Models;
using Task_Mangement.DAL.Repositories.Interfaces;

namespace Task_Mangement.DAL.Repositories.Classes
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        public Task<TEntity> CreateAsync(TEntity entity, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TEntity>> GetByAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }

}
