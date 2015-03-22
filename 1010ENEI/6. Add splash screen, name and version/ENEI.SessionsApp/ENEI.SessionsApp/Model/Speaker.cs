using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ENEI.SessionsApp.Model
{
    public class Speaker : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
