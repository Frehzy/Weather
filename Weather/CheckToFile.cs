using System;
using System.IO;
using System.Windows.Forms;

namespace Weather
{
    class CheckToFile
    {
        public static void CheckFile()
        {
            string directoryfile = Application.StartupPath + "/city.txt";
            if (!File.Exists(directoryfile))
            {
                MessageBox.Show("Пожалуйста, скачайте и установите программу заново", "Не найден файл с городами", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                Application.Exit();
            }
        }
    }
}