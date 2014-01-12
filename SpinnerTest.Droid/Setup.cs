using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using SpinnerTest.Core;

namespace SpinnerTest.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context appContext) : base(appContext) { }

        protected override IMvxApplication CreateApp()
        {
            return new SpinnerTestApp();
        }
    }
}