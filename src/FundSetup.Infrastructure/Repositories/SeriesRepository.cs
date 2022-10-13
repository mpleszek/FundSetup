using FundSetup.Entities.Interfaces;
using FundSetup.Entities.Models;
using FundSetup.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FundSetup.Infrastructure.Repositories
{
    public class SeriesRepository : RepositoryBase<Series>, ISeriesRepository
    {
        public SeriesRepository(DataContext repositoryContext) : base(repositoryContext)
        {

        }

        public void Delete(int id)
        {
            RepositoryContext.Series.Remove(new Series() { Id = id });
            RepositoryContext.SaveChanges();
        }
    }
            
}
