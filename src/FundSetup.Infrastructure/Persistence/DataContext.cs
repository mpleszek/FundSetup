using FundSetup.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Attribute = FundSetup.Entities.Models.Attribute;

namespace FundSetup.Infrastructure.Persistence
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(connectionString);            
        }

        public DbSet<Attribute> Attributes => Set<Attribute>();
        public DbSet<AttributeValue> AttributeValues => Set<AttributeValue>();
        public DbSet<AttributeValueAudit> AttributeValueAudit => Set<AttributeValueAudit>();
        public DbSet<AttributeGroup> AttributeGroups => Set<AttributeGroup>();        
        public DbSet<Fund> Fund => Set<Fund>();
        public DbSet<FundGroup> FundGroup => Set<FundGroup>();
        public DbSet<GroupOwner> GroupOwner => Set<GroupOwner>();
        public DbSet<ProcessInfo> ProcessInfo => Set<ProcessInfo>();
        public DbSet<ProcessReport> ProcessReport => Set<ProcessReport>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductSeries> ProductSeries => Set<ProductSeries>();
        public DbSet<Series> Series => Set<Series>();
        public DbSet<Server> Server => Set<Server>();
        public DbSet<StaticFieldInfo> StaticFieldInfo => Set<StaticFieldInfo>();
        public DbSet<SystemConfiguration> SystemConfiguration => Set<SystemConfiguration>();        
       
    }
}
