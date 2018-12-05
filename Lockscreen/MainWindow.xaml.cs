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
using WpfAnimatedGif;

namespace Lockscreen
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

        public async Task Unlock()
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"/Unlock.gif", UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(gifBackground, image);
        }

        private void ClosingEvent(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Unlock_Click(object sender, RoutedEventArgs e)
        {
            Unlock();
        }
        
        public async Task Shake(int seconds)
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"/Shake.gif", UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(gifBackground, image);

            await Task.Delay(seconds * 1000);

            image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"/Locked.png", UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(gifBackground, image);
        }
    }
}
