using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
        public bool debug = true;

        public MainWindow()
        {
            InitializeComponent();
            FocusManager.SetFocusedElement(WindowMain, codeInputField);
            //Disable window bypassing unless debug is on
            if (!debug)
            {
                IntPtr hModule = GetModuleHandle(IntPtr.Zero);
                hookProc = new LowLevelKeyboardProcDelegate(LowLevelKeyboardProc);
                hHook = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hModule, 0);
                if (hHook == IntPtr.Zero)
                {
                    MessageBox.Show("Failed to hook keyboard, error = " + Marshal.GetLastWin32Error());
                }
            }
        }

        private int tries = 0;
        public async Task Unlock()
        {
            await Task.Delay(0);
            codeInputField.IsEnabled = false;
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
            UnhookWindowsHookEx(hHook); //Remove Keyboard Hook. If this isn't called, there is a chance the user won't be able to use their keyboard afterwards
            System.Windows.Application.Current.Shutdown();
        }

        private void Unlock_Click(object sender, RoutedEventArgs e)
        {
            codeInputField.Text = "12345678";
        }

        public async Task Cooldown(int s)
        {
            await Task.Delay(0);
            codeInputField.IsEnabled = false;
            codeInputField.Text = "";
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"/CooldownBefore.gif", UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(gifBackground, image);

            await Task.Delay(500);

            timeLabel.Visibility = Visibility.Visible;
            TimeSpan ts = TimeSpan.FromSeconds(s);
            for (int i = 0; i < s + 1; i++)
            {
                timeLabel.Content = ts.ToString("m\\:ss");
                ts = ts.Subtract(TimeSpan.FromSeconds(1));
                await Task.Delay(1000);
            }
            timeLabel.Visibility = Visibility.Hidden;

            var img = new BitmapImage();
            codeInputField.Text = "";
            img.BeginInit();
            img.UriSource = new Uri(@"/CooldownAfter.gif", UriKind.Relative);
            img.EndInit();
            ImageBehavior.SetAnimatedSource(gifBackground, img);

            await Task.Delay(1000);

            codeInputField.IsEnabled = true;
            this.codeInputField.Focus();
        }

        public async Task Shake()
        {
            tries++;
            if (tries == 3)
                Cooldown(30);
            else if (tries == 6)
                Cooldown(60);
            else if (tries >= 9 && tries % 3 == 0)
            {
                Cooldown(300);
            }
            else
            {
                await Task.Delay(0);
                codeInputField.IsEnabled = false;
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(@"/Shake.gif", UriKind.Relative);
                image.EndInit();
                ImageBehavior.SetAnimatedSource(gifBackground, image);

                await Task.Delay(500);

                codeInputField.Text = "";
                codeInputField.IsEnabled = true;
                image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(@"/Locked.png", UriKind.Relative);
                image.EndInit();
                ImageBehavior.SetAnimatedSource(gifBackground, image);
                this.codeInputField.Focus();
            }
        }



        public async Task progBar(int value)
        {
            await Task.Delay(0);
            leftBar.SetV(value);
            rightBar.SetV(value);
            switch (value)
            {
                case 1: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F40601")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F40601")); break;
                case 2: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F14100")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F14100")); break;
                case 3: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#EF7900")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#EF7900")); break;
                case 4: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ECB100")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ECB100")); break;
                case 5: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#EAE800")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#EAE800")); break;
                case 6: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#B1E700")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#B1E700")); break;
                case 7: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#78E500")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#78E500")); break;
                case 8: leftBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#3FE200")); rightBar.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#3FE200")); break;
            }
        }

        public async Task checkCode()
        {
            await Task.Delay(0);
            if (Convert.ToInt32(codeInputField.Text) == 12345678)
                Unlock();
            else
                Shake();
        }

        private async void codeInputField_Changed(object sender, TextChangedEventArgs e)
        {
                await Task.Delay(0);
                int SelStart = codeInputField.SelectionStart;
                codeInputField.Text = Regex.Replace(codeInputField.Text, @"\D+", "");
                if (codeInputField.Text.Length > 8)
                    codeInputField.Text = codeInputField.Text.Substring(0, 8);
                codeInputField.Select(SelStart, 0);
                progBar(codeInputField.Text.Length);
            if (codeInputField.Text.Length == 8)
            {
                checkCode();
            }
        }

        private struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }

        private delegate int LowLevelKeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hHook);

        [DllImport("user32.dll")]
        private static extern int CallNextHookEx(int hHook, int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(IntPtr path);

        private IntPtr hHook;
        LowLevelKeyboardProcDelegate hookProc;
        const int WH_KEYBOARD_LL = 13;


        private static int LowLevelKeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
        {
            //What to block
            if (nCode >= 0)
                switch (wParam)
                {
                    case 256: // WM_KEYDOWN
                    case 257: // WM_KEYUP
                    case 260: // WM_SYSKEYDOWN
                    case 261: // M_SYSKEYUP
                        if (
                            (lParam.vkCode == 0x09 && lParam.flags == 32) || // Alt+Tab
                            (lParam.vkCode == 0x1b && lParam.flags == 32) || // Alt+Esc
                            (lParam.vkCode == 0x73 && lParam.flags == 32) || // Alt+F4
                            (lParam.vkCode == 0x1b && lParam.flags == 0) || // Ctrl+Esc
                            (lParam.vkCode == 0x5b && lParam.flags == 1) || // Left Windows Key
                            (lParam.vkCode == 0x5c && lParam.flags == 1))    // Right Windows Key
                        {
                            return 1; //Do not handle key events
                        }
                        break;
                }
            return CallNextHookEx(0, nCode, wParam, ref lParam);
        }
    }

    public static class ProgressBarExtensions
    {
        private static TimeSpan dur = TimeSpan.FromSeconds(0.1);

        public static async void SetV(this ProgressBar progressBar, double val)
        {
            await Task.Delay(0);
            DoubleAnimation a = new DoubleAnimation(val, dur);
            progressBar.BeginAnimation(ProgressBar.ValueProperty, a);
        }
    }
}
