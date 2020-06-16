using Newtonsoft.Json;

namespace Weather.OpenWeather
{
    class OpenWeather
    {
        public Coord coord;
        public Weather[] weather;
        
        [JsonProperty("base")]
        public string Base;

        public Main main;

        public double visibility; //видимость

        public Wind wind;
        public Clounds clounds;

        public double dt; //время получения данных

        public Sys sys;

        public int id; //id города
        public string name; //имя города
        public double cod; //код города
    }
}