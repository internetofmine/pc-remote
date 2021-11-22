
using PcControl.SystemControl;

public static class SystemControlFactory
{
    public static ISystemControl CreateWindowsSystemControl()
    {
        return new WindowsSystemControl();
    }
}
