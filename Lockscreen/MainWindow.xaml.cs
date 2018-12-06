using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string sMemText = "";
        private int sMemNumb = 0;
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

        public async Task progBarUpdate(int value)
        {
            await Task.Delay(0);
            leftBar.Value = value;
            rightBar.Value = value;
        }

        public async Task progBar(int value)
        {
            await Task.Delay(0);
            progBar(value - 9);
            await Task.Delay(0);
            progBar(value - 8);
            await Task.Delay(0);
            progBar(value - 7);
            await Task.Delay(0);
            progBar(value - 6);
            await Task.Delay(0);
            progBar(value - 5);
            await Task.Delay(0);
            progBar(value - 4);
            await Task.Delay(0);
            progBar(value - 3);
            await Task.Delay(0);
            progBar(value - 2);
            await Task.Delay(0);
            progBar(value - 1);
        }

        private void codeInputField_Changed(object sender, TextChangedEventArgs e)
        {
            codeInputField.Text = Regex.Replace(codeInputField.Text, @"\D+", "");
            if (codeInputField.Text.Length > 8)
            {
                codeInputField.Text = sMemText;
            }
            progBar(codeInputField.Text.Length);
            codeInputField.Select(codeInputField.Text.Length, 0);
            sMemText = codeInputField.Text;
            sMemNumb = codeInputField.Text.Length;
        }
    }
}
