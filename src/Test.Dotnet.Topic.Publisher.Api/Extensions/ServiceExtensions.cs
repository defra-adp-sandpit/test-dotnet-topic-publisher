using Test.Dotnet.Topic.Publisher.Core.Interfaces;
using Test.Dotnet.Topic.Publisher.Core.Services;

namespace Test.Dotnet.Topic.Publisher.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
