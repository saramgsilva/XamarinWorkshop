using Android.Content;
using ENEI.SessionsApp.Droid.Services;
using ENEI.SessionsApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShareService))]
namespace ENEI.SessionsApp.Droid.Services
{
    public class ShareService : IShareService
    {
        public void ShareLink(string title, string status, string link)
        {
            var intent = new Intent(global::Android.Content.Intent.ActionSend);
            intent.PutExtra(global::Android.Content.Intent.ExtraText, string.Format("{0} - {1}", status ?? string.Empty, link ?? string.Empty));
            intent.PutExtra(global::Android.Content.Intent.ExtraSubject, title ?? string.Empty);
            intent.SetType("text/plain");
            intent.SetFlags(ActivityFlags.ClearTop);
            intent.SetFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);
        }
    }
}