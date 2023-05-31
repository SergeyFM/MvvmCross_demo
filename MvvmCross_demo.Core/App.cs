using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross_demo.Core.ViewModels;

namespace MvvmCross_demo.Core {
    public class App : MvxApplication {
        public override void Initialize() {
            RegisterAppStart<GuestBookViewModel>();
        }
    }
}
