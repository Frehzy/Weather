namespace Weather.Translate
{
    class CustomTranslate
    {
        public static string CustomDescription(string TextForCustomTranslate)
        {
            //описание погоды (thunderstorm)
            if (Variable.description == "thunderstorm with light rain")
            {
                return "Гроза с небольшим дождем";
            }
            else
            {
                if (Variable.description == "thunderstorm with rain")
                {
                    return "Гроза с дождем";
                }
                else
                {
                    if (Variable.description == "thunderstorm with heavy rain")
                    {
                        return "Гроза с сильным дождем";
                    }
                    else
                    {
                        if (Variable.description == "light thunderstorm")
                        {
                            return "Слабая гроза";
                        }
                        else
                        {
                            if (Variable.description == "thunderstorm")
                            {
                                return "Гроза";
                            }
                            else
                            {
                                if (Variable.description == "heavy thunderstorm")
                                {
                                    return "Сильная гроза";
                                }
                                else
                                {
                                    if (Variable.description == "ragged thunderstorm")
                                    {
                                        return "Местами гроза";
                                    }
                                    else
                                    {
                                        if (Variable.description == "thunderstorm with light drizzle")
                                        {
                                            return "Гроза, слабая изморозь";
                                        }
                                        else
                                        {
                                            if (Variable.description == "thunderstorm with drizzle")
                                            {
                                                return "Гроза, изморозь";
                                            }
                                            else
                                            {
                                                if (Variable.description == "thunderstorm with heavy drizzle")
                                                {
                                                    return "Гроза, сильная изморозь";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //описание погоды (Drizzle)
            if (Variable.description == "light intensity drizzle")
            {
                return "Слабая морось";
            }
            else
            {
                if (Variable.description == "drizzle")
                {
                    return "Морось";
                }
                else
                {
                    if (Variable.description == "heavy intensity drizzle")
                    {
                        return "Сильная морось";
                    }
                    else
                    {
                        if (Variable.description == "light intensity drizzle rain")
                        {
                            return "Слабо моросящий дождь";
                        }
                        else
                        {
                            if (Variable.description == "drizzle rain")
                            {
                                return "Моросящий дождь";
                            }
                            else
                            {
                                if (Variable.description == "heavy intensity drizzle rain")
                                {
                                    return "Сильная изморозь";
                                }
                                else
                                {
                                    if (Variable.description == "shower rain and drizzle")
                                    {
                                        return "Ливень и изморозь";
                                    }
                                    else
                                    {
                                        if (Variable.description == "heavy shower rain and drizzle")
                                        {
                                            return "Сильный ливень и изморозь";
                                        }
                                        else
                                        {
                                            if (Variable.description == "shower drizzle")
                                            {
                                                return "Моросящий дождь";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //описание погоды (rain)
            if (Variable.description == "light rain")
            {
                return "Слабый дождь";
            }
            else
            {
                if (Variable.description == "moderate rain")
                {
                    return "Умеренный дождь";
                }
                else
                {
                    if (Variable.description == "heavy intensity rain")
                    {
                        return "Сильный дождь";
                    }
                    else
                    {
                        if (Variable.description == "very heavy rain")
                        {
                            return "Очень сильный дождь";
                        }
                        else
                        {
                            if (Variable.description == "extreme rain")
                            {
                                return "Экстремально сильный дождь";
                            }
                            else
                            {
                                if (Variable.description == "freezing rain")
                                {
                                    return "Холодный дождь";
                                }
                                else
                                {
                                    if (Variable.description == "light intensity shower rain")
                                    {
                                        return "Умеренный дождь";
                                    }
                                    else
                                    {
                                        if (Variable.description == "shower rain")
                                        {
                                            return "Ливень";
                                        }
                                        else
                                        {
                                            if (Variable.description == "heavy intensity shower rain")
                                            {
                                                return "Сильный ливень";
                                            }
                                            else
                                            {
                                                if (Variable.description == "ragged shower rain")
                                                {
                                                    return "Местами ливень";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //описание погоды (snow)
            if (Variable.description == "light snow")
            {
                return "Небольшой снег";
            }
            else
            {
                if (Variable.description == "snow")
                {
                    return "Снегопад";
                }
                else
                {
                    if (Variable.description == "heavy snow")
                    {
                        return "Сильный снегопад";
                    }
                    else
                    {
                        if (Variable.description == "sleet")
                        {
                            return "Мокрый снег";
                        }
                        else
                        {
                            if (Variable.description == "light shower sleet")
                            {
                                return "Лёгкий мокрый снегопад";
                            }
                            else
                            {
                                if (Variable.description == "shower sleet")
                                {
                                    return "Мокрый снегопад";
                                }
                                else
                                {
                                    if (Variable.description == "light rain and snow")
                                    {
                                        return "Небольшой дождь и снег";
                                    }
                                    else
                                    {
                                        if (Variable.description == "rain and snow")
                                        {
                                            return "Дождь и снег";
                                        }
                                        else
                                        {
                                            if (Variable.description == "light shower snow")
                                            {
                                                return "Небольшой мокрый снегопад";
                                            }
                                            else
                                            {
                                                if (Variable.description == "shower snow")
                                                {
                                                    return "Мокрый снегопад";
                                                }
                                                else
                                                {
                                                    if (Variable.description == "heavy shower snow")
                                                    {
                                                        return "Сильный мокрый снегопад";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //описание погоды (snow)
            if (Variable.description == "Light snow")
            {
                return "Небольшой снег";
            }
            else
            {
                if (Variable.description == "Snow")
                {
                    return "Снегопад";
                }
                else
                {
                    if (Variable.description == "Heavy snow")
                    {
                        return "Сильный снегопад";
                    }
                    else
                    {
                        if (Variable.description == "Sleet")
                        {
                            return "Мокрый снег";
                        }
                        else
                        {
                            if (Variable.description == "Light shower sleet")
                            {
                                return "Лёгкий мокрый снегопад";
                            }
                            else
                            {
                                if (Variable.description == "Shower sleet")
                                {
                                    return "Мокрый снегопад";
                                }
                                else
                                {
                                    if (Variable.description == "Light rain and snow")
                                    {
                                        return "Небольшой дождь и снег";
                                    }
                                    else
                                    {
                                        if (Variable.description == "Rain and snow")
                                        {
                                            return "Дождь и снег";
                                        }
                                        else
                                        {
                                            if (Variable.description == "Light shower snow")
                                            {
                                                return "Небольшой мокрый снегопад";
                                            }
                                            else
                                            {
                                                if (Variable.description == "Shower snow")
                                                {
                                                    return "Мокрый снегопад";
                                                }
                                                else
                                                {
                                                    if (Variable.description == "Heavy shower snow")
                                                    {
                                                        return "Сильный мокрый снегопад";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //описание погоды (Atmosphere)
            if (Variable.description == "Mist")
            {
                return "Лёгкий туман";
            }
            else
            {
                if (Variable.description == "Smoke")
                {
                    return "Туманно";
                }
                else
                {
                    if (Variable.description == "Haze")
                    {
                        return "Сильный туман";
                    }
                    else
                    {
                        if (Variable.description == "sand/dust whirls")
                        {
                            return "Пылевая буря";
                        }
                        else
                        {
                            if (Variable.description == "Sand/dust whirls")
                            {
                                return "Пылевая буря";
                            }
                            else
                            {
                                if (Variable.description == "dust whirls")
                                {
                                    return "Пылевая буря";
                                }
                                else
                                {
                                    if (Variable.description == "fog")
                                    {
                                        return "Туманно";
                                    }
                                    else
                                    {
                                        if (Variable.description == "sand")
                                        {
                                            return "Пылевая буря";
                                        }
                                        else
                                        {
                                            if (Variable.description == "dust")
                                            {
                                                return "Пылевая буря";
                                            }
                                            else
                                            {
                                                if (Variable.description == "volcanic ash")
                                                {
                                                    return "Буря из вулканического пепла";
                                                }
                                                else
                                                {
                                                    if (Variable.description == "squalls")
                                                    {
                                                        return "Густые облака";
                                                    }
                                                    else
                                                    {
                                                        if (Variable.description == "tornado")
                                                        {
                                                            return "Смерч/Торнадо";
                                                        }
                                                        else
                                                        {
                                                            if (Variable.description == "haze")
                                                            {
                                                                return "Сильный туман";
                                                            }
                                                            else
                                                            {
                                                                if (Variable.description == "smoke")
                                                                {
                                                                    return "Туманно";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //описание погоды (Clear)
            if (Variable.description == "clear sky")
            {
                return "Чистое небо";
            }
            //описание погоды (Clouds)
            if (Variable.description == "few clouds")
            {
                return "Мало облаков (11-25 %)";
            }
            else
            {
                if (Variable.description == "scattered clouds")
                {
                    return "Рассеянные облака (25-50 %)";
                }
                else
                {
                    if (Variable.description == "broken clouds")
                    {
                        return"Облачно (51-84 %)";
                    }
                    else
                    {
                        if (Variable.description == "overcast clouds")
                        {
                            return "Пасмурные облака (85-100 %)";
                        }
                    }
                }
            }
            return "Нет данных";
        }

        public static string CustomMainWeather(string TextForCustomTranslate)
        { 
            //погода
            if (Variable.mainWeather == "Clouds")
            {
                return "Облачно";
            }
            else
            {
                if (Variable.mainWeather == "Rain")
                {
                    return "Дождливо";
                }
                else
                {
                    if (Variable.mainWeather == "Snow")
                    {
                        return "Снегопад";
                    }
                    else
                    {
                        if (Variable.mainWeather == "Clear sky")
                        {
                            return "Безоблачное небо";
                        }
                        else
                        {
                            if (Variable.mainWeather == "Thunderstorm")
                            {
                                return "Гроза";
                            }
                            else
                            {
                                if (Variable.mainWeather == "Drizzle")
                                {
                                    return "Мелкий дождь/Моросящий дождь";
                                }
                                else
                                {
                                    if (Variable.mainWeather == "Atmosphere")
                                    {
                                        return "Смешанная погода";
                                    }
                                    else
                                    {
                                        if (Variable.mainWeather == "Mist")
                                        {
                                            return "Лёгкий туман";
                                        }
                                        else
                                        {
                                            if (Variable.mainWeather == "Smoke")
                                            {
                                                return "Туманно";
                                            }
                                            else
                                            {
                                                if (Variable.mainWeather == "Haze")
                                                {
                                                    return "Туманно";
                                                }
                                                else
                                                {
                                                    if (Variable.mainWeather == "Dust")
                                                    {
                                                        return "Туманно/Пыльно";
                                                    }
                                                    else
                                                    {
                                                        if (Variable.mainWeather == "Fog")
                                                        {
                                                            return "Туманно";
                                                        }
                                                        else
                                                        {
                                                            if (Variable.mainWeather == "Sand")
                                                            {
                                                                return "Туманно";
                                                            }
                                                            else
                                                            {
                                                                if (Variable.mainWeather == "Ash")
                                                                {
                                                                    return "Туман, перемешанный с пеплом";
                                                                }
                                                                else
                                                                {
                                                                    if (Variable.mainWeather == "Squall")
                                                                    {
                                                                        return "Густые облака";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (Variable.mainWeather == "Tornado")
                                                                        {
                                                                            return "Смерч/Торнадо";
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return "Нет данных";
        }
        public static string CustomWindDeg(double TextForCustomTranslate_double)
        {
            //направление ветра
            if (Variable.WindDeg >= 335 && Variable.WindDeg <= 22)
            {
                return "Направление ветра: " + "Северное направление (" + Variable.WindDeg.ToString() + ")";
            }
            else
            {
                if (Variable.WindDeg >= 23 && Variable.WindDeg <= 68)
                {
                    return "Направление ветра: " + "Северо-восточное направление (" + Variable.WindDeg.ToString() + ")";
                }
                else
                {
                    if (Variable.WindDeg >= 69 && Variable.WindDeg <= 112)
                    {
                        return "Направление ветра: " + "Восточное направление (" + Variable.WindDeg.ToString() + ")";
                    }
                    else
                    {
                        if (Variable.WindDeg >= 113 && Variable.WindDeg <= 157)
                        {
                            return "Направление ветра: " + "Юго-восточное направление (" + Variable.WindDeg.ToString() + ")";
                        }
                        else
                        {
                            if (Variable.WindDeg >= 158 && Variable.WindDeg <= 202)
                            {
                                return "Направление ветра: " + "Южное направление (" + Variable.WindDeg.ToString() + ")";
                            }
                            else
                            {
                                if (Variable.WindDeg >= 203 && Variable.WindDeg <= 247)
                                {
                                    return "Направление ветра: " + "Юго-западное направление (" + Variable.WindDeg.ToString() + ")";
                                }
                                else
                                {
                                    if (Variable.WindDeg >= 248 && Variable.WindDeg <= 302)
                                    {
                                        return "Направление ветра: " + "Западное направление (" + Variable.WindDeg.ToString() + ")";
                                    }
                                    else
                                    {
                                        if (Variable.WindDeg >= 303 && Variable.WindDeg <= 334)
                                        {
                                            return "Направление ветра: " + "Северо-западное направление (" + Variable.WindDeg.ToString() + ")";
                                        }
                                        else
                                        {
                                            return "Направление ветра: " + "Ошибка получения данных";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}