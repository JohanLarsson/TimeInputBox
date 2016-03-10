namespace TimeInputBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using TimeInputBox.Annotations;

    public class Time : INotifyPropertyChanged
    {
        private int hours;
        private int minutes;
        public event PropertyChangedEventHandler PropertyChanged;

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value == hours) return;
                hours = value;
                OnPropertyChanged();
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value == minutes) return;
                minutes = value;
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