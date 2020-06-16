namespace Weather.OpenWeather
{
    class Main
    {
        //температура
        private double _temp;
        public double temp
        {
            get
            {
                return _temp;
            }
            set
            {
                _temp = value - 273.15;
            }
        }

        private double _feels_like;
        public double feels_like
        {
            get
            {
                return _feels_like;
            }
            set
            {
                _feels_like = value - 273.15;
            }
        }

        //давление
        private double _pressure;
        public double pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = value / 1.3332239;
            }
        }

        //влажность
        public double humidity;

        //минимальная температура
        private double _temp_min;
        public double temp_min
        {
            get
            {
                return _temp_min;
            }
            set
            {
                _temp_min = value - 273.15;
            }
        }

        //максимальная температура
        private double _temp_max;
        public double temp_max
        {
            get
            {
                return _temp_max;
            }
            set
            {
                _temp_max = value - 273.15;
            }
        }
    }
}