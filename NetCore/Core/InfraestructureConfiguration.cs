using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Core
{
    public class InfrastructureConfiguration
    {
        public FeatureFlags FeatureFlags { get; set; }
    }

    public class FeatureFlags
    {
        public bool UseSwagger { get; set; }
    }
}
