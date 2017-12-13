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
    [Activity(Label = "mainWindow", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class mainWindow : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.mainWindow);





            //Create your application here
            ImageView fishbot = FindViewById<ImageView>(Resource.Id.imgFishbot);
            ImageView auction = FindViewById<ImageView>(Resource.Id.imgAuctioning);
            ImageView processing = FindViewById<ImageView>(Resource.Id.imgProcessing);
            ImageView chat = FindViewById<ImageView>(Resource.Id.imgChat);

            fishbot.Click += delegate
            {
                Intent intent = new Intent(this, typeof(FishBot));
                StartActivity(intent);
            };
            //for Second Screen now


            auction.Click += delegate
            {
                Intent intent = new Intent(this, typeof(SecondActivity));

                StartActivity(intent);
            };


            //For Third SCreen now 
            processing.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ThirdActivity));

                StartActivity(intent);
            };

            //Fourth Screen
            chat.Click += delegate
            {
                Intent intent = new Intent(this, typeof(FourthActivity));

                StartActivity(intent);
            };








        }
    }
}