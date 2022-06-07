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

namespace WPF_Clock_Stopwatch_Timer.Views
{
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
        DispatcherTimer timer = new DispatcherTimer();
        public Clock()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(TimerClick);
            timer.Start();


        }

        public void TimerClick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            ClockLabel.Content = $"{d:HH:mm:ss}";
        }
    }
}
