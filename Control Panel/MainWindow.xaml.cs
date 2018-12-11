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


namespace Control_Panel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool qrIsRevealed = false;
        public static int category = 0;
        public MainWindow()
        {
            InitializeComponent();
            updateVisuals();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        { SystemCommands.CloseWindow(this); }

        private void MinBtn_Click(object sender, RoutedEventArgs e)
        { SystemCommands.MinimizeWindow(this); }

        public async Task updateVisuals()
        {
            await Task.Delay(0);
            TitleL.Content = this.Title;
            if (category == 0)
            {
                generalGrid.Visibility = Visibility.Visible;
                setupGrid.Visibility = Visibility.Hidden;
                settingsGrid.Visibility = Visibility.Hidden;
            }
            else if (category == 1)
            {
                generalGrid.Visibility = Visibility.Hidden;
                setupGrid.Visibility = Visibility.Visible;
                settingsGrid.Visibility = Visibility.Hidden;
            }
            else if (category == 2)
            {
                generalGrid.Visibility = Visibility.Hidden;
                setupGrid.Visibility = Visibility.Hidden;
                settingsGrid.Visibility = Visibility.Visible;
            }
            if (qrIsRevealed)
                qrView.Source = new BitmapImage(new Uri(qrPath));
            else
                qrView.Source = new BitmapImage(new Uri("pack://application:,,,/AssemblyName;component/EmptyQRCode.png"));
        }

        private void TitleDrag(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { /* Most Likely Caused By Right-Clicking */ }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Normal;
            this.Height = 450;
            this.Width = 800;
        }

        private void GeneralBtn_Click(object sender, RoutedEventArgs e)
        {
            category = 0;
            updateVisuals();
        }

        private void SetupBtn_Click(object sender, RoutedEventArgs e)
        {
            category = 1;
            updateVisuals();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            category = 2;
            updateVisuals();
        }

        private void RevealQR_Click(object sender, RoutedEventArgs e)
        {
            if (qrIsRevealed)
                qrIsRevealed = false;
            else
                qrIsRevealed = true;
            updateVisuals();
        }
    }
}
