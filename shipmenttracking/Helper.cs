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

namespace shipmenttracking
{
    class Helper
    {
        internal static List<oneItem> shipItem;
        public void getItems()
        {
            shipItem = new List<oneItem>();
            // get all items from data
            return;
        }
    }
}