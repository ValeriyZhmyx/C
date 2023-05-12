using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class StatisticDisplay : Observer, DisplayElement
    {
        private float max_temp;
        private float min_temp;
        private float sum_temp;
        private float num_readings;
        private float avg_temp;

        public StatisticDisplay(Subject weatherData)
        {
            max_temp = 0;
            min_temp = 200;
            sum_temp = 0;
            num_readings = 0;
            avg_temp = 0;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            avg_temp = sum_temp / num_readings;
            Console.WriteLine("Statistics Avg/Max/Min temp = {0}/{1}/{2}",avg_temp,max_temp,min_temp);
        }

        public void update(float temp, float humidity, float pressure)
        {
            sum_temp += temp;
            num_readings += 1;

            if (temp > max_temp) 
            {
                max_temp = temp;
            };

            if (temp < min_temp)
            {
                min_temp = temp;
            };

            display();
        }
    }

}
