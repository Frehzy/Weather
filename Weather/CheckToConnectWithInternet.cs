using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Weather
{
    class CheckToConnectWithInternet
    {
        //проверка интеренета по флагам
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetGetConnectedState(out int lpdwFlags, int dwReserved);
        [Flags]
        enum ConnectionStates
        {
            Modem = 0x1,
            LAN = 0x2,
            Proxy = 0x4,
            RasInstalled = 0x10,
            Offline = 0x20,
            Configured = 0x40,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsConnected();
        }

        //проверка подключения к интернету
        public static void IsConnected()
        {
            int flags;
            bool isConnected = InternetGetConnectedState(out flags, 0);
            if (isConnected == false)
            {
                MessageBox.Show("Проверьте подключение к Интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                Application.Exit();
            }
        }
    }
}