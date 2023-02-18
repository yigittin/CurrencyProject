using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CurrenyProject.Data;
using Volo.Abp.DependencyInjection;

namespace CurrenyProject.EntityFrameworkCore;

public class EntityFrameworkCoreCurrenyProjectDbSchemaMigrator
    : ICurrenyProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCurrenyProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CurrenyProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CurrenyProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
