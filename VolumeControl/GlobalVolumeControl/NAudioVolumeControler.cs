namespace PcControl.VolumeControl
{
    public class NAudioVolumeControler : IVolumeControler
    {
        public void Mute()
        {
            SetAllDevicesMute(true);
        }

        public void UnMute()
        {
            SetAllDevicesMute(false);
        }

        //https://stackoverflow.com/questions/154089/mute-windows-volume-using-c-sharp
        private void SetAllDevicesMute(bool muteStatus)
        {
            var MMDE = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var DevCol = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);

            foreach (var dev in DevCol)
            {
                try
                {
                    dev.AudioEndpointVolume.Mute = muteStatus;
                }
                catch (Exception ex)
                {
                    //Do something with exception when an audio endpoint could not be muted
                }
            }
        }
    }
}
