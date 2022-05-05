﻿using Framework2.Infra.Data.Entity;

namespace Framework2.Domain.Core.Responses
{
    public abstract class FxEntityCommandResponse : FxCommandResponse
    {
        public IDataObject? Item { get; set; }
        public bool Success { get; set; } = true;
    }
}
