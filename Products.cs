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
using SQLite;

namespace testingAPP
{
    public class Products
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            return string.Format("[Products: ID={0}, Name={1}, Price={2}]", ID, Name, Price);
        }




    }
}