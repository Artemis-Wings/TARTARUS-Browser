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
using CefSharp;
using CefSharp.Wpf;

namespace TARTARUS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ChromiumWebBrowser_OnFrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Dispatcher.BeginInvoke((Action)(() => 
            {
                BackBtn.IsEnabled = Browser.CanGoBack;
                ForwartBtn.IsEnabled = Browser.CanGoForward;
            }));
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.Back();
            }
        }
        private void ForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.Forward();
            }



        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Browser.Address = "www.google.com";
        }
        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            Browser.Reload(true);
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            Browser.Address = "https://artemis-wings.github.io/Tartarus/";
        }
    }
}