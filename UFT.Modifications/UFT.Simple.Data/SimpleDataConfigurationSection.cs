using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple.Data
{
    using System.Configuration;
    using System.Diagnostics;

    public class SimpleDataConfigurationSection
    {
        public SimpleDataConfigurationSection()
        {
            TraceLevel = TraceLevel.Info;
        }        
        public TraceLevel TraceLevel { get; set; }
    }
}
