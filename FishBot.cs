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
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Json;
using System.Net.Http;
using System.Collections.Specialized;

namespace testingAPP
{
    [Activity(Label = "FishBot" ,Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class FishBot : Activity
    {
       public TextView Start1;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.botfish);

            Start1 = FindViewById<TextView>(Resource.Id.txtgetStart1);

            String temp = FetchWeatherAsync().ToString();
            
            //try { 
           
            
            ////if(int.Parse(data)==0)
            ////  {
            ////        var starcount1 = json["data"];
            ////        Start1.Text = "" + starcount1;
            //// }
            //}
            //catch(Exception ex)
            //{
            //    Start1.Text = "" + ex;
            //}

            //    Thread STart1Thread = new System.Threading.Thread(new
            //System.Threading.ThreadStart(threadFunction));
            //    STart1Thread.Start();

        }




        //Public ThreadFUnction

        public void threadFunction()
        {
            String Data = "";


            using (var client = new WebClient())
            {
                Start1.Text = "Thread is running";

                Android.Telephony.TelephonyManager mTelephonyMgr;
                mTelephonyMgr = (Android.Telephony.TelephonyManager)GetSystemService(TelephonyService);


                String m_deviceId = mTelephonyMgr.DeviceId;

                var values = new NameValueCollection();
                values["mobileToken"] = m_deviceId;

                try
                {
                   

                    var response = client.UploadValues("http://alustin.net/api.php?action=create", values);

                    var responseString = Encoding.Default.GetString(response);
                    Data = responseString.ToString();
                    //var json = JsonValue.Parse(responseString);
                    //var data = json["code"];

                    //Start1.Text = json.ToString();

                }
                catch (Exception ex)
                {
                    Data = "Ex";
                   

            }




            }







            if(Data=="Ex")

                Toast.MakeText(this, "Exception Error", ToastLength.Long).Show();
            else
            {
                Start1.Text = Data;
            }



        }










        private async Task<JsonValue> FetchWeatherAsync()
        {
            try
            {
               
                var values = new Dictionary<string, string>
                {

                   { "mobileToken", "1337"}
                };
                HttpClient client = new HttpClient();
              
                var content = new FormUrlEncodedContent(values);
                
                var response = await client.PostAsync("http://alustin.net/api.php?action=getstat1", content);
                
                var responseString = await response.Content.ReadAsStringAsync();

                //Toast.MakeText(this, "" + responseString, ToastLength.Long);
                var json = JsonValue.Parse(responseString);
                var data = json["code"];

                if (int.Parse(data) == 0)
                {
                    
                   var count = json["data"].ToString();
                    var countParser = JsonValue.Parse(count);
                       var counter= countParser["count"];
                    Start1.Text = counter;
                }
                   
                return responseString;
            }
            catch (Exception ex)
            {
                Start1.Text = ex.ToString();

            }
            return null;
        }

















    }









}