using System.Diagnostics;

namespace PcControl.SystemControl
{
    public class WindowsSystemControl : ISystemControl
    {
        //https://stackoverflow.com/questions/102567/how-to-shut-down-the-computer-from-c-sharp
        public void Shutdown()
        {
            ExecuteProcess("Shutdown", "/s /t 0", true, false);
        }

        public void ShutdownForce()
        {
            ExecuteProcess("Shutdown", "/s /t /f 0", true, false);
        }

        private void ExecuteProcess(string command, string options, bool createNoWindow, bool useShellExecute)
        {
            var psi = new ProcessStartInfo(command, options);
            psi.CreateNoWindow = createNoWindow;
            psi.UseShellExecute = useShellExecute;
            Process.Start(psi);
        }
    }
}
