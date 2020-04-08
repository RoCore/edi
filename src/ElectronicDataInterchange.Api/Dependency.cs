using Microsoft.Extensions.DependencyInjection;

namespace ElectronicDataInterchange.Api
{
    public static class Dependency
    {
        public static IServiceCollection Register(this IServiceCollection collection)
        {
            return collection;
        }
    }
}
