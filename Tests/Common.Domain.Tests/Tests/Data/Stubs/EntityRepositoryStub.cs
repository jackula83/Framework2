﻿using Common.Domain.Core.Data;
using Common.Domain.UnitTests.Interfaces;
using Common.Domain.UnitTests.Tests.Models.Stubs;

namespace Common.Domain.UnitTests.Tests.Data.Stubs
{
    public class EntityRepositoryStub : FxEntityRepository<SqlServerDbContextStub, EntityStub>, IEntityRepositoryStub
    {
        public EntityRepositoryStub(SqlServerDbContextStub context) : base(context)
        {
        }
    }
}