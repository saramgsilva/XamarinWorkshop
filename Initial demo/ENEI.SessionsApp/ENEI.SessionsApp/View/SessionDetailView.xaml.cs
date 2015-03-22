using ENEI.SessionsApp.Model;
using Xamarin.Forms;

namespace ENEI.SessionsApp.View
{
    public partial class SessionDetailView : ContentPage
    {
        private readonly Session _session;

        public SessionDetailView(Session session)
        {
            _session = session;
            InitializeComponent();
            Title = session.Name;
            BindingContext = session;
        }
    }
}
