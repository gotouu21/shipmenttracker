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
    class ApiHelper
    {
        string baseUrl = "https://api.trackingmore.com/v2";
        void trackingStatus(string carrier, string trackno)
        {
            API.Tracker()
        }
        void detectCarrier(string trackno)
        {
            API.Tracker()
        }
    }
}