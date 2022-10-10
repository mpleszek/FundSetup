using FundSetup.Entities.Interfaces;
using FundSetup.Entities.Models;
using FundSetup.Entities.Persistence;

namespace FundSetup.Entities.Repositories
{
    public class SeriesRepository : RepositoryBase<Series>, ISeriesRepository
    {
        public SeriesRepository(DataContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
