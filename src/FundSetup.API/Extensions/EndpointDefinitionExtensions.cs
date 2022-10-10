using FundSetup.API.Interfaces;

namespace Fund.API.Extensions
{
    public static class EndpointDefinitionExtensions
    {

        public static void AddEndpointDefinitions( this IServiceCollection services, params Type[] scanMarkers)
        {
            var endpointDefinitions = new List<IEndpointDefinition>();

            foreach (var marker in scanMarkers)
            {
                endpointDefinitions.AddRange(
                    marker.Assembly.ExportedTypes
                    .Where(x => typeof(IEndpointDefinition)
                    .IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                    .Select(Activator.CreateInstance)
                    .Cast<IEndpointDefinition>()
                    );
            }

            foreach (var endpoint in endpointDefinitions)
            {
                endpoint.DefineServices(services);
            }

            services.AddSingleton(endpointDefinitions as IReadOnlyCollection<IEndpointDefinition>);
        }

        public static void UseEndpointDefinitions(this WebApplication app)
        {
            var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpointDefinition>>();

            foreach (var def in definitions)
            {
                def.DefineEndpoints(app);
            }
        }
    }
}
