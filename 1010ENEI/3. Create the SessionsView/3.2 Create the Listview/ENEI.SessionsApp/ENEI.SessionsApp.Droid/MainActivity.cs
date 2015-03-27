
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace ENEI.SessionsApp.Droid
{
    [Activity(Label = "ENEI.SessionsApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.SetIcon(Resource.Drawable.ic_action_users);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

