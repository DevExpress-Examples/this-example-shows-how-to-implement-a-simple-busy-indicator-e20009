using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Threading;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            busyIndicator.Visibility = Visibility.Visible;
            try {
                ThreadPool.QueueUserWorkItem(OnCompleted);
            }
            catch {
                busyIndicator.Visibility = Visibility.Collapsed;
                throw;
            }
        }

        void OnCompleted(object state) {
            Thread.Sleep(1000);
            Dispatcher.BeginInvoke(() => {
                //
                busyIndicator.Visibility = Visibility.Collapsed;
            });
        }
    }
}
