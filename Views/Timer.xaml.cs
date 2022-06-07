using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;

namespace WPF_Clock_Stopwatch_Timer.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopWatch = new Stopwatch();
        string currentTime = string.Empty;
        int time = 59;
        public UserControl1()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(timer_tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1);

        }
        public void timer_tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                if (time > 0) {
                    Chronometer1.Content = "00:" + time--;
                }
                
            }

        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
                StartButton.Content = "Start";

            }
            else
            {
                StartButton.Content = "Pause";
                stopWatch.Start();
                dispatcherTimer.Start();
            }



        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Reset();
                StartButton.Content = "Start";


            }
            time = 59;
            Chronometer1.Content = "01:00";

        }
    }
}

