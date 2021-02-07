using System;
using System.Threading;
using System.Windows.Forms;

namespace DogOnTop
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(false, "DogOnTopMutex"))
            {
                if (!mutex.WaitOne(TimeSpan.Zero) &&
                    (MessageBox.Show("僅可執行一個 DogOnTop", "DogOnTop", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainForm());
                mutex.ReleaseMutex();
            }
        }
    }
}
