using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWebserver03.Interfaces
{
    public interface IWeatherService
    {
        string GetWeatherData();
    }

    public class WeatherService : IWeatherService
    {
        public string GetWeatherData()
        {
            return "Sunny, 25°C";
        }
    }
}