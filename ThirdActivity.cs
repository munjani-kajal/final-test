using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace testingAPP
{
    [Activity(Label = "ThirdActivity", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class ThirdActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.third);

        }
    }
}