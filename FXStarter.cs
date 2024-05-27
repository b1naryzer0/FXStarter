using System;
using System.Diagnostics;

namespace Starter
{
    internal class Program
    {
        static void Main()
        {
            System.Diagnostics.ProcessStartInfo exe =
            new System.Diagnostics.ProcessStartInfo();
            exe.FileName = "C:\\Program Files\\FxSound LLC\\FxSound\\FxSound.exe";
            exe.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; //Hides GUI
            exe.CreateNoWindow = true; //Hides console

            try
            {
                foreach (var process in Process.GetProcessesByName("fxsound"))
                {
                    process.Kill();
                }
                Process.Start(exe);
            }
            catch
            {

            }
        }
    }
}
