﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.IntegrationTests.MQ.Stubs
{
    public interface ITestEventMonitor
    {
        void EventMonitored(TestEvent @event);
    }
}