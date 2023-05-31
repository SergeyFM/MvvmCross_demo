using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Core;

namespace MvvmCross_demo.Wpf
{
    public class Setup : MvxWpfSetup<MvvmCross_demo.Core.App> {
        protected override ILoggerProvider CreateLogProvider() {
            return null;
        }

        protected override ILoggerFactory CreateLogFactory() {
            // serilog configuration
            return null;
        }
    }
}
