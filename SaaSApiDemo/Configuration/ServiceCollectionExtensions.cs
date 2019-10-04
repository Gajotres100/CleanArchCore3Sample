using Akka.Actor;
using Application.UserCases.Tenants;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;
using NSwag.Generation.AspNetCore;

namespace SaaSApiDemo.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static void AddOpenApi(this IServiceCollection services)
        {
            services
                .AddOpenApiDocument(
                    options => InitializeOpenApiDocumentOptions(options, "v1"))
                .AddOpenApiDocument(
                    options => InitializeOpenApiDocumentOptions(options, "v2"));

        }

        public static void AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(
                options =>
                {
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.ReportApiVersions = true;
                    options.ApiVersionReader = new UrlSegmentApiVersionReader();
                });
            services.AddVersionedApiExplorer(
                options =>
                {
                    options.GroupNameFormat = "'v'VVV";
                    options.SubstitutionFormat = "VVV";
                    options.SubstituteApiVersionInUrl = true;
                    options.ApiVersionParameterSource = new UrlSegmentApiVersionReader();
                });
        }

        private static void InitializeOpenApiDocumentOptions(AspNetCoreOpenApiDocumentGeneratorSettings options, string version)
        {
            options.DocumentName = version;
            options.Title = $"Demo API {version}";
            options.ApiGroupNames = new[] { version };

            options.Description = "A demo API";
            options.IgnoreObsoleteProperties = true;
        }

        public static void AddDiContainer(this IServiceCollection services)
        {
            services.AddSingleton(_ => ActorSystem.Create("saasapi"));

            services.AddSingleton<TenantActorProvider>(provider =>
            {
                var actorSystem = provider.GetService<ActorSystem>();
                var tenantManagerActor = actorSystem.ActorOf(Props.Create(() => new TenantManagerActor()));
                return () => tenantManagerActor;
            });

        }
    }
}
