using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using SpinnerTest.Core.ViewModels;

namespace SpinnerTest.Droid.Views
{
    [Activity(Label = "First")]
    public class FirstView : MvxActivity
    {
        public new FirstViewModel ViewModel
        {
            get { return (FirstViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.firstview);
        }
    }
}