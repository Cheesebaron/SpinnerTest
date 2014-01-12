using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SpinnerTest.Droid.NoMvx
{
    [Activity(Label = "SpinnerTest.Droid.NoMvx", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var spinner = FindViewById<Spinner>(Resource.Id.spinner);
            var text = FindViewById<TextView>(Resource.Id.text);

            var colors = new[] {Color.Red, Color.Azure, Color.Aqua, Color.BlanchedAlmond};
            spinner.Adapter = new MySpinnerAdapter(this, Resource.Layout.spinneritem, Resource.Id.spinnerText, colors);

            spinner.ItemSelected += (s, e) =>
            {
                var color = colors[e.Position];
                text.SetBackgroundColor(color);
                text.Text = color.ToHtmlColorCode();
            };
        }
    }

    public class MySpinnerAdapter : ArrayAdapter<Color>
    {
        private readonly int _resource;
        private readonly int _resourceId;

        public MySpinnerAdapter(Context context, int resource, int textViewResourceId, IList<Color> objects)
            : base(context, resource, textViewResourceId, objects)
        {
            _resource = resource;
            _resourceId = textViewResourceId;
        }

        public override View GetDropDownView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.FromContext(Context);
            var view = convertView ?? inflater.Inflate(_resource, parent, false);
            var textView = view.FindViewById<TextView>(_resourceId);
            textView.Text = GetItem(position).ToHtmlColorCode();
            return view;
        }
    }

    public static class MyColorExtensions
    {
        public static string ToHtmlColorCode(this Color color)
        {
            return string.Format("#{0}{1}{2}{3}", color.A.ToString("X"), color.R.ToString("X"), color.G.ToString("X"),
                color.B.ToString("X"));
        }
    }
}
