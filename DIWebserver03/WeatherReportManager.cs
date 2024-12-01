using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIWebserver03.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DIWebserver03
{
    public class WeatherReportManager
    {
        private readonly IWeatherService _weatherService;
        private readonly INotificationService _notificationService;

        public WeatherReportManager(IWeatherService weatherService,INotificationService notificationService)
        {
            _weatherService = weatherService ?? throw new ArgumentNullException(nameof(weatherService));;
            _notificationService = notificationService?? throw new ArgumentNullException(nameof(notificationService));
        }

        public void GenerateReport()
        {
            var weatherData = _weatherService.GetWeatherData();
            _notificationService.Notify($"Weather Report: {weatherData}");
        }
    }
}