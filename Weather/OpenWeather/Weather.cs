using System.Drawing;

namespace Weather.OpenWeather
{
    class Weather
    {
        public int id; //id погоды
        public string main; //тип погоды (дождь, снег и тд)
        public string description; //описание

        //иконка
        public string icon;
        public Bitmap Icon
        {
            get
            {
                return new Bitmap(Image.FromFile($"icons/{icon}.png"));
            }
        }
    }
}