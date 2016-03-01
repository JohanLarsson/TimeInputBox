using System;
using System.Windows;

namespace TimeInputBox
{
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for TimeInputControl.xaml
    /// </summary>
    public partial class TimeInputControl : UserControl
    {
        public static readonly DependencyProperty TimeProperty = DependencyProperty.Register(
            "Time",
            typeof(Time),
            typeof(TimeInputControl),
            new PropertyMetadata(default(Time)));

        public TimeInputControl()
        {
            InitializeComponent();
        }

        public Time Time
        {
            get { return (Time)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        private void OnIncreaseMinutesClick(object sender, RoutedEventArgs e)
        {
            if (Time != null)
            {
                var minutes = Time.Minutes;
                Time.Minutes = minutes < 59 ? minutes + 1 : 00;
            }
        }

        private void OnIncreaseHourseClick(object sender, RoutedEventArgs e)
        {
            if (Time != null)
            {
                var hours = Time.Hours;
                Time.Hours = hours < 24 ? hours + 1 : 00;
            }
        }

        private void OnDecreaseHourseClick(object sender, RoutedEventArgs e)
        {
            if (Time != null)
            {
                var hours = Time.Hours;
                Time.Hours = hours > 0 ? hours - 1 : 24;
            }
        }

        private void OnDecreaseMinutesClick(object sender, RoutedEventArgs e)
        {
            if (Time != null)
            {
                var minutes = Time.Minutes;
                Time.Minutes = minutes > 0 ? minutes - 1 : 59;
            }
        }
    }
}
