using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAutch;
        EditText editText1;

        EditText editText2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAutch = FindViewById<Button>(Resource.Id.btnAutch);

            editText1 = FindViewById<EditText>(Resource.Id.editText1);
            editText2 = FindViewById<EditText>(Resource.Id.editText2);

            btnAutch.Click += DoAuthentication;
        }
        private void DoAuthentication(object sender, EventArgs e)
        {
           if (editText1.Text.Equals("bichito") && editText2.Text.Equals("123456"))
            {
                Toast.MakeText(this, "Usuario valido", ToastLength.Short);


            }
            else
            {
                Toast.MakeText(this, "Usuario invalido", ToastLength.Short)
                    .Show();
            }
        }
    }
}

