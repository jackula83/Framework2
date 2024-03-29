﻿using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Framework2.Infra.Data.Context
{
    /// <summary>
    /// DbContext that will work with SQL Server only
    /// </summary>
    public abstract class FxSqlServerDbContext : FxDbContext
    {
        protected FxSqlServerDbContext(DbContextOptions options, IMediator mediator) : base(options, mediator)
        {
        }

        protected override void Setup<TEntityType>(ModelBuilder builder)
        {
            builder.Entity<TEntityType>(x =>
            {
                x.Property(p => p.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();
            });
        }
    }
}
