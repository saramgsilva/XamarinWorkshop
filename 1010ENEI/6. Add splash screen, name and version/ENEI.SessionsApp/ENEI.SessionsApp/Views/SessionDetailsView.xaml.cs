
using ENEI.SessionsApp.Model;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Views
{
    public partial class SessionDetailsView : ContentPage
    {
        private readonly Session _session;

        public SessionDetailsView(Session session)
        {
            _session = session;
            InitializeComponent();
            Title = session.Name;
            BindingContext = session;
        }
    }
}
