﻿using System;
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
        public static Uri qrPath = new Uri(@"C:\test.png"); //The users QR code path here! Thank
        public static bool qrIsRevealed = false;
        public MainWindow()
        {
            InitializeComponent();
            updateVisuals(-1);
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        { SystemCommands.CloseWindow(this); }

        private void MinBtn_Click(object sender, RoutedEventArgs e)
        { SystemCommands.MinimizeWindow(this); }

        public async Task updateVisuals(int category)
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
        }

        private void TitleDrag(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { /* Most Likely Caused By Right-Clicking */ }
        }


        private void GeneralBtn_Click(object sender, RoutedEventArgs e)
        {
            updateVisuals(0);
        }

        private void SetupBtn_Click(object sender, RoutedEventArgs e)
        {
            updateVisuals(1);
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            updateVisuals(2);
        }

        private void RevealQR_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (qrIsRevealed)
                    qrView.Source = new BitmapImage(qrPath);
                else
                    qrView.Source = new BitmapImage(new Uri("pack://application:,,,/AssemblyName;component/EmptyQRCode.png"));
            } catch { /*File missing or moved... Probably */ }
        }
    }
}
