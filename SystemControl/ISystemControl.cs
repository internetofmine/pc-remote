namespace PcControl.SystemControl
{
    public interface ISystemControl
    {
        void Shutdown();
        void ShutdownForce();
    }
}