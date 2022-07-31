﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.AutomationLinkObserver.ObserverBase
{
    public interface IChannelObserver
    {
        void Update(float valueToBeUpdatedTo);
    }
}
