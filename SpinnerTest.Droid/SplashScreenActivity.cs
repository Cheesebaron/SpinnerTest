using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace SpinnerTest.Droid
{
    [Activity(Label = "Spinner Test", MainLauncher = true)]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity() : base(Resource.Layout.splashscreen) {
            
        }
    }
}