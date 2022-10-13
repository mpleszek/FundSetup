using FundSetup.Entities.Interfaces;
using FundSetup.Infrastructure.Repositories;
using FundSetup.API.Interfaces;
using FundSetup.Entities.Models;
using Microsoft.EntityFrameworkCore;

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

            app.MapPost("/series", (ISeriesRepository repo, Series entity) =>
            {
                repo.Create(entity);
            })
            .WithName("PostSeries");

            app.MapDelete("/series/{id}", (ISeriesRepository repo, int id) =>
                {
                    repo.Delete(id);
                })
            .WithName("DeleteSeries");

            app.MapPut("/series/", (ISeriesRepository repo, Series entity) =>
            {
                repo.Update(entity);
            })
            .WithName("PutSeries");
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddScoped<ISeriesRepository, SeriesRepository>();
        }
    }
}
