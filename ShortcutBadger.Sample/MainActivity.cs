using Android.App;
using Android.Widget;
using Android.OS;
using ME.Leolin.Shortcutbadger;

namespace ShortcutBadger.Sample
{
    [Activity(Label = "ShortcutBadger.Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int badgeNumber = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button increase = FindViewById<Button>(Resource.Id.increaseBtn);
            Button reset = FindViewById<Button>(Resource.Id.setNullBadgeBtn);

            increase.Click += Increase_Click;
            reset.Click += Reset_Click;
        }

        private void Reset_Click(object sender, System.EventArgs e)
        {
            ME.Leolin.Shortcutbadger.ShortcutBadger.RemoveCount(this);
        }

        private void Increase_Click(object sender, System.EventArgs e)
        {
            ME.Leolin.Shortcutbadger.ShortcutBadger.ApplyCount(this, badgeNumber++);
        }
    }
}

