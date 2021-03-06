﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Smellyriver.TankInspector.Modeling
{
    [Serializable]
    internal static class BenchmarkDamageableComponent
    {
        internal static void Initialize(VirtualDamageableComponent target, IEnumerable<IDamageableComponent> modules)
        {
            target.MaxHealth = modules.Average(m => m.MaxHealth);
            target.MaxRegenHealth = modules.Average(m => m.MaxRegenHealth);
            target.RepairCostFactor = modules.Average(m => m.RepairCostFactor);
            target.BulkHealthFactor = modules.Average(m => m.BulkHealthFactor);
        }
    }
}
