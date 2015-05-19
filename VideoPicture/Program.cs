using System;
using System.Windows.Forms;

namespace VideoPicture
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.Unlocked == false)
                Application.Run(new UnlockForm());

            if (Properties.Settings.Default.Unlocked)
                Application.Run(new MainForm());
        }
    }
}
