﻿namespace Common.Domain.Core.Models
{
    public abstract class FxEntityCommandRequest<TEntity> : FxCommandRequest
        where TEntity : FxEntity
    {
        public TEntity? Item { get; set; }
    }
}
