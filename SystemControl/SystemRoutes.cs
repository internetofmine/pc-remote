namespace PcControl.SystemControl
{
    public static class SystemRoutes
    {
        internal static void Configure(WebApplication app, ISystemControl systemControl)
        {
            app.MapPost("/shutdown", () =>
            {
                try
                {
                    systemControl.ShutdownForced();
                }
                catch (Exception ex)
                {
                    //When something happend that prevent us to iterate through the devices
                }
            });

        }
    }
}
