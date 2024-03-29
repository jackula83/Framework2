﻿using Framework2.Infra.Data.Context;
using Framework2.Infra.Data.UnitTests.Tests.Models.Stubs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Framework2.Infra.Data.UnitTests.Tests.Data.Stubs
{
    public class SqlServerDbContextStub : FxSqlServerDbContext
    {
        public DbSet<EntityStub> Entities { get; set; }

#pragma warning disable 8618
        public SqlServerDbContextStub(DbContextOptions options, IMediator mediator) : base(options, mediator)
        {
        }
#pragma warning restore 8618
    }
}
