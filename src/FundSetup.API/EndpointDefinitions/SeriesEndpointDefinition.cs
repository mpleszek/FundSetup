using FundSetup.Entities.Interfaces;
using FundSetup.Entities.Repositories;
using FundSetup.API.Interfaces;


namespace FundAPI.EndpointDefinitions
{
    public class SeriesEndpointDefinition : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {

            app.MapGet("/series", (ISeriesRepository repo) =>
            {
                return repo.FindAll();
            })
            .WithName("GetSeries");
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddScoped<ISeriesRepository, SeriesRepository>();
        }
    }
}
