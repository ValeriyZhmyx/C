using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay current = new CurrentConditionsDisplay(weatherData);
            StatisticDisplay stat = new StatisticDisplay(weatherData);

            weatherData.SetMeasurements(-1, 20, 720);
            weatherData.SetMeasurements(-100, 20, 770);
            weatherData.SetMeasurements(-122, 20, 780);


        }
    }
}
