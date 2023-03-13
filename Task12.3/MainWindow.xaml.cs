using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task12._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Stopwatch _stopWatch;
        private Timer _timer;
        private string _startTimeDisplay = Model.StartTimeDisplay;

        public MainWindow()
        {
            InitializeComponent();
            TimeDisplay.Text = _startTimeDisplay;
            _stopWatch = Model.StopWatch;
            _timer = Model.Timer;
            _timer.Elapsed += OnTimerElapse;
        }

        private void OnTimerElapse(object sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() => TimeDisplay.Text = _stopWatch.Elapsed.ToString(@"hh\:mm\:ss"));
        }

        private void Start_Click_OnClick_Click(object sender, RoutedEventArgs e)
        {
            _stopWatch.Start();
            _timer.Start();
            Stop_Click.IsEnabled = false;
        }

        private void Pause_Click_OnClick(object sender, RoutedEventArgs e)
        {
            _stopWatch.Stop();
            _timer.Stop();
            Stop_Click.IsEnabled = true;

        }

        private void Stop_Click_OnClick_Click(object sender, RoutedEventArgs e)
        {
            _stopWatch.Reset();
            TimeDisplay.Text = _startTimeDisplay;
        }
    }
}
