using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;

namespace HTPCAVRVolume.AVRDevices
{
    class DenonMarantzDevice : IAVRDevice
    {
        private string _IP;

        public DenonMarantzDevice(string IP)
        {
            _IP = IP;
        }

        public void VolUp()
        {
            SendCmd("MVUP");
        }

        public void VolDown()
        {
            SendCmd("MVDOWN");
        }

        public void ToggleMute(bool muted)
        {
            if (muted)
            {
                SendCmd("MUOFF");
            }
            else
            {
                SendCmd("MUON");
            }
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
                MessageBox.Show($"Error connecting to Denon / Marantz at: {_IP}:23", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AVRConn?.Close();
            }
        }
    }
}