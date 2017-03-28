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

namespace TestAlarmApplication.BroadCast
{
    [BroadcastReceiver (Enabled = true)]
    class AlarmToastReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "THIS IS MY ALARM", ToastLength.Long).Show();

        }
    }
}