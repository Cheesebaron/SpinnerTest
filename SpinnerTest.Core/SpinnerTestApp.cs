using Cirrious.MvvmCross.ViewModels;
using SpinnerTest.Core.ViewModels;

namespace SpinnerTest.Core
{
    public class SpinnerTestApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FirstViewModel>();
        }
    }
}
