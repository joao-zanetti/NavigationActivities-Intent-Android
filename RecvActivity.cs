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

namespace Navigater
{
    [Activity(Label = "RecvActivity")]
    public class RecvActivity : Activity
    {
        TextView textView1;
        TextView textView2;
        Button buttonBack;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.recvactivity);

            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView2 = FindViewById<TextView>(Resource.Id.textView2);
            buttonBack = FindViewById<Button>(Resource.Id.buttonBack);

            string text1 = Intent.GetStringExtra("name" ?? "Not rec");
            string text2 = Intent.GetStringExtra("email" ?? "Not rec");

            textView1.Text = text1;
            textView2.Text = text2;

            buttonBack.Click += delegate
            {
                this.Finish();
            };

        }
    }
}