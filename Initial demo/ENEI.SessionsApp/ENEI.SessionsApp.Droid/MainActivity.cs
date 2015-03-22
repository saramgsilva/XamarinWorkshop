using Android.App;
using Android.Content;
using Android.Content.PM;

using Android.OS;

namespace ENEI.SessionsApp.Droid
{
    [Activity(Label = "1010 ENEI", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash",
 ConfigurationChanges = ConfigChanges.ScreenSize, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }

    [Activity(Label = "1010 ENEI", Theme = "@style/Theme.ENEI", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
  
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            ActionBar.SetIcon(Resource.Drawable.ic_action_users);
            LoadApplication(new App());
        }
    }
}

