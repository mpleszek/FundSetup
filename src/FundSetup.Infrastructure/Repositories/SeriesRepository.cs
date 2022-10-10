using FundSetup.Entities.Interfaces;
using FundSetup.Entities.Models;
using FundSetup.Infrastructure.Persistence;

namespace FundSetup.Infrastructure.Repositories
{
    public class SeriesRepository : RepositoryBase<Series>, ISeriesRepository
    {
        public SeriesRepository(DataContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
