using System.Diagnostics;

namespace PcControl.SystemControl
{
    public class WindowsSystemControl : ISystemControl
    {
        //https://stackoverflow.com/questions/102567/how-to-shut-down-the-computer-from-c-sharp
        public void Shutdown()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
    }
}
