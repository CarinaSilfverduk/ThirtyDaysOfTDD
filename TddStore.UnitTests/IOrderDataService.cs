﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddStore.Core;

namespace TddStore.UnitTests
{
    public interface IOrderDataService
    {
        Guid Save(Order order);
    }
}
