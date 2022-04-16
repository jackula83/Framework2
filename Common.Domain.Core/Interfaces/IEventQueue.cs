﻿using Common.Domain.Core.Handlers;
using Common.Domain.Core.Models;

namespace Common.Domain.Core.Interfaces
{
    public interface IEventQueue
    {
        Task Publish<TEvent>(TEvent @event) 
            where TEvent : FxEvent;
        Task Subscribe<TEvent, TEventHandler>()
            where TEvent : FxEvent
            where TEventHandler : FxEventHandler<TEvent>;
        Task<uint> Count<TEvent>()
            where TEvent : FxEvent;
    }
}
