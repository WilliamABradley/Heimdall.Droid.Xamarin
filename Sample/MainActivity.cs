using System;
using Android.App;
using Android.OS;
using Sample.Models.OAuth;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}