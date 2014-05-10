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
using Microsoft.Phone.Controls;

namespace HeartBeat
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Collapsed;
            button2.Visibility = Visibility.Visible;
            beat.Begin();
        }

        private void button1_Click_2(object sender, RoutedEventArgs e)
        {
            button2.Visibility = Visibility.Collapsed;
            button1.Visibility = Visibility.Visible;
            beat.Stop();
        }

        private void ApplicationBarPulseIconButton_Click(object sender, EventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarInfoIconButton_Click(object sender, EventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/Info.xaml", UriKind.Relative));
        }

        private void ApplicationBarSettingIconButton_Click(object sender, EventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        } 
    }
}