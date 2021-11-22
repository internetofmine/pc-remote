using PcControl.VolumeControl;

namespace PcControl
{
    public static class GlobalVolumeRoutes
    {
        internal static void Configure(WebApplication app, IVolumeControler volumeControler)
        {
            app.MapPost("/mute", () =>
            {
                try
                {
                    volumeControler.Mute();
                }
                catch (Exception ex)
                {
                    //When something happend that prevent us to iterate through the devices
                }
            });

            app.MapPost("/unmute", () =>
            {
                try
                {
                    volumeControler.UnMute();
                }
                catch (Exception ex)
                {
                    //When something happend that prevent us to iterate through the devices
                }
            });
        }
    }
}
