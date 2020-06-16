using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Weather.Translate;

namespace Weather
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckToConnectWithInternet.IsConnected(); //проверка подключения к интернету
            CheckToFile.CheckFile(); //проверка существования файла с городами
        }

        //кнопка выхода
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
            Application.Exit();
        }

        //кнопка обновить
        private async void metroButton2_Click(object sender, EventArgs e)
        {
            CheckToConnectWithInternet.IsConnected(); //проверка подключения к интернету
            CheckToFile.CheckFile(); //проверка существования файла с городами
            try
            {
                WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?id=" + idTextBox.Text + "&APPID=002ad5987fae2bde5067fd5195691cbc");
                //получение данных с сайта методом Post
                request.Method = "POST";
                request.ContentType = "application/x-www-urlencoded";
                WebResponse response = await request.GetResponseAsync();
                string answer = string.Empty;
                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }
                response.Close();
                OpenWeather.OpenWeather oW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

                //отправка переменных для перевода
                Variable.description = oW.weather[0].description;
                Variable.mainWeather = oW.weather[0].main;
                Variable.WindDeg = oW.wind.deg;

                if (Variable.isYandexTranslate == true)
                {
                    //перевод yandex
                    mainLabel.Text = YandexTranslator.Translate(Variable.mainWeather);
                    descriptionLabel.Text = YandexTranslator.Translate(Variable.description);
                }
                else
                {
                    //без перевода
                    mainLabel.Text = CustomTranslate.CustomMainWeather(Variable.mainWeather);
                    descriptionLabel.Text = CustomTranslate.CustomDescription(Variable.description);
                }

                //заполнение информацией
                panel1.BackgroundImage = oW.weather[0].Icon;
                tempLabel.Text = "Средняя температура в данный момент (°С): " + oW.main.temp.ToString("0.##");
                datetimeLabel.Text = "Время получения данных с сервера: " + DateTime.Now.ToString();
                countryLabel.Text = oW.name.ToString();
                speedLabel.Text = "Скорость ветра (м/с): " + oW.wind.speed.ToString();
                pressureLabel.Text = "Атмосферное давление (мм.рт.ст): " + ((int)oW.main.pressure).ToString();
                humidityLabel.Text = "Влажность (%): " + oW.main.humidity.ToString();
                feels_likeLabel.Text = "Температура по ощущениям (°С): " + oW.main.feels_like.ToString("0.##");
                degLabel.Text = CustomTranslate.CustomWindDeg(Variable.WindDeg);

                ExceptionHandling(); //обработка исключений
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainLabel.Text = "Ошибка";
                descriptionLabel.Text = "Ошибка";
                pressureLabel.Text = "Ошибка";
                humidityLabel.Text = "Ошибка";
                speedLabel.Text = "Ошибка";
                degLabel.Text = "Ошибка";
                countryLabel.Text = "Ошибка";
                tempLabel.Text = "Ошибка";
                feels_likeLabel.Text = "Ошибка";
            }
            idTextBox.Text = "ID города";
            IDInfo.Visible = false;
        }

        //переход на сайт
        private void link_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://openweathermap.org/");
        }

        //кнопка поиска города
        private void metroButton3_Click(object sender, EventArgs e)
        {
            CheckToFile.CheckFile(); //проверка существования файла с городами
            //проверка на заполение поля
            if ((countryTextBox.Text != String.Empty) && (countryTextBox.Text.Length > 2))
            {
                //очистка всех полей
                mainLabel.Text = "main";
                descriptionLabel.Text = "description";
                pressureLabel.Text = "pressure";
                humidityLabel.Text = "humidity";
                speedLabel.Text = "speed";
                degLabel.Text = "deg";
                countryLabel.Text = "country";
                tempLabel.Text = "temp";
                feels_likeLabel.Text = "feels_like";
                datetimeLabel.Text = "datetime";

                //поиск по бд всех городов с таким ключевым словом
                string keyWord = countryTextBox.Text;
                var lines = File.ReadLines(Application.StartupPath + "/city.txt");
                string result = string.Join("\n", lines.Where(s => s.IndexOf(keyWord, StringComparison.InvariantCultureIgnoreCase) >= 0));
                if (result.Length == 0)
                {
                    MessageBox.Show($"Ничего не найдено по данному ключевому слову: {keyWord}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(result, $"Найденные ID по ключевому слову {keyWord}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IDInfo.Text = result;
                    IDInfo.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели ключевое слово или оно слишком короткое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            countryTextBox.Text = "Название города";
        }

        //исчезнование текста при наведении
        private void countryTextBox_Click(object sender, EventArgs e)
        {
            if ((countryTextBox.Text == "Название города") || (countryTextBox.Text.Length == 0))
            {
                countryTextBox.Text = "";
                IDInfo.Text = "";
                IDInfo.Visible = false;
            }
        }
        //исчезнование текста при наведении
        private void idTextBox_Click(object sender, EventArgs e)
        {
            if ((idTextBox.Text == "ID города") || (idTextBox.Text.Length == 0))
            {
                idTextBox.Text = "";
            }
        }

        //инструкция
        private void metroButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Введите город или любое ключевое слово города, у котором хотите узнать информацию, в соответствующее поле (на английском)\n" +
                            "2. Нажмите кнопку 'Найти город'\n" +
                            "3. Найдите в появившемся списке свой город, скопируйте и вставьте ID города в соответствующее поле таким образом, чтобы в поле ID находились только цифры\n" +
                            "4. Нажмите кнопку 'Обновить'", 
                            "Инструкция по работе с программой", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //чек, включить яндекс перевод или пользоваться кастомным
        private void YandexTranslateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (YandexTranslateCheckBox.Checked == true)
                Variable.isYandexTranslate = true;
            else
                Variable.isYandexTranslate = false;
        }

        //обработка исключений
        public void ExceptionHandling()
        {
            if (mainLabel.Text == "main")
            { mainLabel.Text = "Нет данных"; }
            if (descriptionLabel.Text == "description")
            { descriptionLabel.Text = "Нет данных"; }
            if (pressureLabel.Text == "pressure")
            { pressureLabel.Text = "Нет данных"; }
            if (humidityLabel.Text == "humidity")
            { humidityLabel.Text = "Нет данных"; }
            if (speedLabel.Text == "speed")
            { speedLabel.Text = "Нет данных"; }
            if (degLabel.Text == "deg")
            { degLabel.Text = "Нет данных"; }
            if (countryLabel.Text == "country")
            { countryLabel.Text = "Нет данных"; }
            if (tempLabel.Text == "temp")
            { tempLabel.Text = "Нет данных"; }
            if (feels_likeLabel.Text == "feels_like")
            { feels_likeLabel.Text = "Нет данных"; }
            if (datetimeLabel.Text == "datetime")
            { datetimeLabel.Text = "Нет данных"; }
        }
    }
}