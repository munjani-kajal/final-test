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
using System.Net;
using System.Json;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Specialized;
using SQLite;

namespace testingAPP
{
    [Activity(Label = "FirstScreen", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class FirstScreen : Activity
    {
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.FirstScreen);

            EditText name = FindViewById<EditText>(Resource.Id.editText1);
            EditText price = FindViewById<EditText>(Resource.Id.editText2);
            Button btnAdd = FindViewById<Button>(Resource.Id.btnAdd);

            btnAdd.Click += delegate
            {
                Products pro1 = new Products();

                pro1.Name = name.Text;
                pro1.Price = price.Text;
                insert(pro1, "Products");
                
                Finish();

            };

           







        }
        private bool insert(Products data, string path)
        {
            try
            {
                var db = new SQLiteAsyncConnection(path);
                db.InsertAsync(data);
               
                 
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }



    }






  






}