
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ENEI.SessionsApp.Model
{
    public class Session : INotifyPropertyChanged
    {
        private int _numLikes;
        private Speaker _speaker;
        private string _date;
        private string _description;
        private string _name;
        private bool _isFavorite;
        private string _schedule;
        private string _room;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }

        public int NumLikes
        {
            get { return _numLikes; }
            set { _numLikes = value; OnPropertyChanged();}
        }

        public Speaker Speaker
        {
            get { return _speaker; }
            set { _speaker = value; OnPropertyChanged(); }
        }

        public bool IsFavorite
        {
            get { return _isFavorite; }
            set { _isFavorite = value; OnPropertyChanged();}
        }

        public string Schedule
        {
            get { return _schedule; }
            set { _schedule = value; OnPropertyChanged(); }
        }

        public string Room
        {
            get { return _room; }
            set { _room = value; OnPropertyChanged(); }
        }

        public string Details
        {
            get { return string.Format("{0} | {1} | Sala {2} ", Date, Schedule, Room); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
