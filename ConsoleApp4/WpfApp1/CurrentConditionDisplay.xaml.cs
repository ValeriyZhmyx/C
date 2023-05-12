using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class CurrentConditionDisplay : Window, Observer
    {
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            
            InitializeComponent();
            this.weatherData = weatherData;
        }
        public void update(float temp, float humidity, float pressure)
        {
            lable1.Content = temp.ToString();
            lable1_Copy.Content = humidity.ToString();
            lable1_Copy1.Content = pressure.ToString();
            float a = (temp + humidity + pressure) / 3;
            lable1_Copy2.Content = a.ToString();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            weatherData.registerObserver(this);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            weatherData.removeObserver(this);
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
