using BankAccountApi.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BankAccountApi
{
    public static class ContainerConfig
    {
        public static void ConfigContainer(this IServiceCollection services)
        {
            services.AddTransient(typeof(IAccountRepository), typeof(AccountRepository));
        }
    }
}
