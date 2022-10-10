using FundSetup.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using FundSetup.Infrastructure.Persistence;


namespace FundSetup.Infrastructure.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected DataContext RepositoryContext { get; set; }

        public RepositoryBase(DataContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition)
        {
            return RepositoryContext.Set<T>().Where(condition).AsNoTracking();
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
