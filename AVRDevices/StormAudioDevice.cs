using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;

namespace HTPCAVRVolume.AVRDevices
{
    class StormAudioDevice : IAVRDevice
    {
        private string _IP;

        public StormAudioDevice(string IP)
        {
            _IP = IP;
        }

        public void VolUp()
        {
            SendCmd("ssp.vol.up");
        }

        public void VolDown()
        {
            SendCmd("ssp.vol.down");
        }

        public void ToggleMute(bool muted)
        {

            SendCmd("ssp.mute.toggle");
        }

        private void SendCmd(string cmd)
        {
            TcpClient AVRConn = new TcpClient();
            try
            {
                AVRConn.Connect(_IP, 23);

                byte[] cmdBytes = Encoding.ASCII.GetBytes(cmd + "\r");
                AVRConn.GetStream().Write(cmdBytes, 0, cmdBytes.Length);
                AVRConn.Close();
            }
            catch
            {
                MessageBox.Show($"Error connecting to StormAudio at: {_IP}:23", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AVRConn?.Close();
            }
        }
    }
}