﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cayman.ReservasApp.Data;
using Volo.Abp.DependencyInjection;

namespace Cayman.ReservasApp.EntityFrameworkCore;

public class EntityFrameworkCoreReservasAppDbSchemaMigrator
    : IReservasAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreReservasAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ReservasAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ReservasAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
