using System;
using System.Collections.ObjectModel;
using ENEI.SessionsApp.Data;
using ENEI.SessionsApp.Interfaces;
using ENEI.SessionsApp.Model;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Views
{
    public partial class SessionsView : ContentPage
    {
        public SessionsView()
        {
            InitializeComponent();
            Sessions = new ObservableCollection<Session>();
            BindingContext = this;
        }

        public ObservableCollection<Session> Sessions { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Sessions.Count == 0)
            {
                var sessions = SessionsDataSource.GetSessions();
                foreach (var session in sessions)
                {
                    Sessions.Add(session);
                }
            }
        }

        private void SessionsList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (SessionsList.SelectedItem == null)
            {
                return;
            }

            SessionsList.SelectedItem = null;
        }

        private void FavoriteGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var tappedEventArg = e as TappedEventArgs;
            if (tappedEventArg != null)
            {
                var session = tappedEventArg.Parameter as Session;
                if (session != null)
                {
                    session.IsFavorite = !session.IsFavorite;
                }
            }
        }

        private void ShareGesture_OnTapped(object sender, EventArgs e)
        {
            var tappedEventArg = e as TappedEventArgs;
            if (tappedEventArg != null)
            {
                var session = tappedEventArg.Parameter as Session;
                if (session != null)
                {
                    var shareService = DependencyService.Get<IShareService>();
                    if (shareService != null)
                    {
                        var status = string.Format("Não percas a sessão {0} de {1}.", session.Name, session.Speaker.Name);
                        shareService.ShareLink("ENEI 2015", status, "https://enei.pt/");
                    }
                }
            }
        }

        private void DetailsGesture_OnTapped(object sender, EventArgs e)
        {
            var tappedEventArg = e as TappedEventArgs;
            if (tappedEventArg != null)
            {
                var session = tappedEventArg.Parameter as Session;
                if (session != null)
                {
                    Navigation.PushAsync(new SessionDetailsView(session), true);
                }
            }
        }


        private void LikeGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var tappedEventArg = e as TappedEventArgs;
            if (tappedEventArg != null)
            {
                var session = tappedEventArg.Parameter as Session;
                if (session != null)
                {
                    session.NumLikes++;
                }
            }
        }
    }
}
