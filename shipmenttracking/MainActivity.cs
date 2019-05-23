using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;

namespace shipmenttracking
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lst;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            lst = FindViewById<ListView>(Resource.Id.list_view);
            lst.Adapter = new ShipAdapter(this,Helper.shipItem);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu1, menu);
            return true;
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if(item.ItemId==Resource.Id.action_add)
            {
                // add item
                // pop up menu
                Helper.addItem();

            }
            if(item.ItemId == Resource.Id.action_quit)
            {
                Helper.saveItems();
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            }
            return true;
        }
    }
}

