using System;
using ENEI.SessionsApp.Interfaces;
using ENEI.SessionsApp.WinPhone.Services;
using Microsoft.Phone.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShareService))]
namespace ENEI.SessionsApp.WinPhone.Services
{
    public class ShareService : IShareService
    {
        public void ShareLink(string title, string status, string link)
        {
            var task = new ShareLinkTask { Title = title, Message = status, LinkUri = new Uri(link) };
            Device.BeginInvokeOnMainThread(() =>
            {
                try
                {
                    task.Show();
                }
                catch (Exception ex)
                {
                 // todo handle the error   
                }
            });
        }
    }
}
