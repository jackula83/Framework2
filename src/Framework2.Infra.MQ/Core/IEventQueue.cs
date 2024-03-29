﻿namespace Framework2.Infra.MQ.Core
{
    public interface IEventQueue : IPublishQueue
    {
        Task Subscribe<TEvent, TEventHandler>()
            where TEvent : FxEvent
            where TEventHandler : FxEventHandler<TEvent>;
        Task<uint> Count<TEvent>()
            where TEvent : FxEvent;
    }
}
