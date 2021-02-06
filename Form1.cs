using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DogOnTop
{
    public partial class mainForm : Form
    {
        private const int HWND_TOPMOST = -1;
        private const int HWND_NOTOPMOST = -2;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOSIZE = 0x0001;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpWindowClass, string lpWindowName);

        private static IntPtr intPtrDesktop;
        private static bool timerLock = true;

        public mainForm()
        {
            InitializeComponent();
            timerWatch.Tag = null;
            intPtrDesktop = FindWindow("Progman", "Program Manager");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            EnableWatchTimer(true);
            buttonStart.Enabled = false;
            buttonCancel.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            EnableWatchTimer(false);
            buttonStart.Enabled = true;
            buttonCancel.Enabled = false;
        }

        private void timerWatch_Tick(object sender, EventArgs e)
        {
            IntPtr intPtr = GetForegroundWindow();
            if (intPtr == Process.GetCurrentProcess().MainWindowHandle ||
                intPtr == intPtrDesktop ||
                timerLock)
            {
                return;
            }
            else
            {
                if (watchPanel.RectangleToScreen(watchPanel.ClientRectangle).Contains(MousePosition))
                {
                    EnableWatchTimer(false);
                    timerWatch.Tag = intPtr;
                    string topTitle = GetActiveWindowTitle(intPtr) ?? "";
                    DialogResult result = MessageBox.Show(topTitle, "開始置頂", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.OK && SetWindowPos(intPtr, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE))
                    {
                        labelWatch.Text = topTitle + " 置頂中...";
                        ShowTrayIcon(false);
                    }
                }
            }
        }

        private void EnableWatchTimer(bool enable)
        {
            timerLock = !enable;
            timerWatch.Enabled = enable;
            if (!enable && timerWatch.Tag != null)
            {
                SetWindowPos((IntPtr)timerWatch.Tag, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
                timerWatch.Tag = null;
                labelWatch.Text = "";
            }
        }

        private void ShowTrayIcon(bool enable)
        {
            if (enable)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                iconDogOnTop.Visible = false;
            }
            else
            {
                Hide();
                iconDogOnTop.Visible = true;
                iconDogOnTop.ShowBalloonTip(2000);
            }
        }

        private string GetActiveWindowTitle(IntPtr handle)
        {
            const int nChars = 512;
            StringBuilder Buff = new StringBuilder(nChars);
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EnableWatchTimer(false);
        }

        private void iconDogOnTop_DoubleClick(object sender, EventArgs e)
        {
            ShowTrayIcon(true);
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowTrayIcon(false);
            }
        }
    }
}
