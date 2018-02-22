using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get 
            EditText emailBox = FindViewById<EditText>(Resource.Layout.Main);
            EditText passwordBox = FindViewById<EditText>(Resource.Layout.Main);

            // MAKE EMAILBOX STRING INTO BOOLEAN, THEN CHECK IF TRUE OR FALSE

            bool emailBool;


            if (emailBool == 0)
            {
                System.Console.WriteLine("Enter a valid email adress!");
            }
            
        }
    }
}

