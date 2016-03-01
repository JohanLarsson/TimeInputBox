using System.ComponentModel;
using System.Runtime.CompilerServices;
using TimeInputBox.Annotations;

namespace TimeInputBox
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Time time = new Time { Hours = 22, Minutes = 07 };
        public event PropertyChangedEventHandler PropertyChanged;

        public Time Time
        {
            get { return time; }
            set
            {
                if (Equals(value, time)) return;
                time = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
