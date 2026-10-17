using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Mangement.DAL.Models;

namespace Task_Mangement.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity:BaseEntity,new()
    {
        public Task<TEntity> CreateAsync(TEntity entity,CancellationToken ct=default);
        public Task<IReadOnlyList<TEntity>> GetByAllAsync(CancellationToken ct = default);
        public Task<TEntity?> GetByIdAsync(int id,CancellationToken ct = default);
        public void UpdateAsync(TEntity entity);
        public void DeleteAsync(TEntity entity);
    }
}
