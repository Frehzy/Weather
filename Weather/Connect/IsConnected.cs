using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class IsConnected
    {
        //проверка подключения к интернету
        public static void Connected()
        {
            int flags;
            bool isConnected = InternetGetConnectedState(out flags, 0);
            if (isConnected == false)
            {
                MessageBox.Show("Проверьте подключение к Интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                Environment.Exit(0);
                Application.Exit();
            }
        }
    }
}
