using System.Net.Http;
using HomeCinema.Data.Repositories;
using HomeCinema.Entities;
using HomeCinema.Services.Abstract;

namespace HomeCinema.Web.Infrastructure.Extensions
{
    public static class RequestMessageExtensions
    {
        internal static IMembershipService GetMembershipService(this HttpRequestMessage request)
        {
            return request.GetService<IMembershipService>();
        }

        private static TService GetService<TService>(this HttpRequestMessage request)
        {
            var dependencyScope = request.GetDependencyScope();
            var service = (TService) dependencyScope.GetService(typeof (TService));

            return service;
        }

        internal static IEntityBaseRepository<T> GetDataRepository<T>(this HttpRequestMessage request)
            where T : class, IEntityBase, new()
        {
            return request.GetService<IEntityBaseRepository<T>>();
        }
    }
}