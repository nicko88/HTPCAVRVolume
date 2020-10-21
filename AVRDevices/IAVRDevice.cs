namespace HTPCAVRVolume.AVRDevices
{
    interface IAVRDevice
    {
        void VolUp();
        void VolDown();
        void ToggleMute(bool muted);
    }
}