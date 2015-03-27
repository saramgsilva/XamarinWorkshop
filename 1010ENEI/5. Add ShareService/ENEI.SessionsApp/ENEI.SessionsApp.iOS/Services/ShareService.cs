using System;
using ENEI.SessionsApp.iOS.Services;
using ENEI.SessionsApp.Interfaces;
using Foundation;
using Social;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShareService))]
namespace ENEI.SessionsApp.iOS.Services
{
    public class ShareService : IShareService
    {
        public void ShareLink(string title, string status, string link)
        {
            var buttonTitle = string.Empty;
            var actionSheet = new UIActionSheet("Partilhar");
            actionSheet.AddButton("Facebook");
            actionSheet.AddButton("Twitter");
            actionSheet.Clicked += delegate(object a, UIKit.UIButtonEventArgs b)
            {
                if (b.ButtonIndex != -1)
                {
                    buttonTitle = actionSheet.ButtonTitle(b.ButtonIndex);
                }
            };
            actionSheet.Dismissed += (sender, e) =>
            {
                if (buttonTitle.Equals("Facebook"))
                {
                    ShareOnService(SLServiceKind.Facebook, title, status, link);
                }
                else if (buttonTitle.Equals("Twitter"))
                {
                    ShareOnService(SLServiceKind.Twitter, title, status, link);
                }
            };
            actionSheet.ShowInView(UIApplication.SharedApplication.KeyWindow.RootViewController.View);
        }
        private void ShareOnService(SLServiceKind service, string title, string status, string link)
        {
            var slComposer = SLComposeViewController.FromService(service);
            if (SLComposeViewController.IsAvailable(service))
            {
                slComposer = SLComposeViewController.FromService(service);
                slComposer.SetInitialText(status);
                slComposer.SetInitialText(title != null ? String.Format("{0} {1}", title, status) : status);
                if (link != null)
                {
                    slComposer.AddUrl(new NSUrl(link));
                }
                slComposer.CompletionHandler += result =>
                {
                    UIApplication.SharedApplication.KeyWindow.RootViewController.InvokeOnMainThread(() =>
                    {
                        UIApplication.SharedApplication.KeyWindow.RootViewController.DismissViewController(true, null);
                    });
                };
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(slComposer, true, null);
            }
        }
    }
}