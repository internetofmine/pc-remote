namespace PcControl.VolumeControl
{
    public static class VolumeControlFactory
    {
        public static IVolumeControler CreateNAudioVolumeControl()
        {
            return new NAudioVolumeControler();
        }
    }
}
