using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading;
using SQLite;
using static Android.OS.Build;

namespace testingAPP
{
    [Activity(Label = "testingAPP", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            Button btnInsert = FindViewById<Button>(Resource.Id.button1);
            Button btnView = FindViewById<Button>(Resource.Id.button2);
            Button btninventry = FindViewById<Button>(Resource.Id.button3);

            createDatabase("Products");
            




            btnInsert.Click += delegate
            {
                StartActivity(new Intent(this, typeof(FirstScreen)));
            };

            btnView.Click += delegate
            {
                StartActivity(new Intent(this, typeof(SecondActivity)));
            };
            btninventry.Click += delegate
            {
                StartActivity(new Intent(this, typeof(ThirdActivity)));
            };








        }








        private bool createDatabase(string path)
        {
            try
            {
                var connection = new SQLiteAsyncConnection(path);
                connection.CreateTableAsync<VERSION>();
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

    }
}

