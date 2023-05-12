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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Subject
    {
        List<Observer> observers;
        private float temp;
        private float humidity;
        private float pressure;

        public MainWindow()
        {
            InitializeComponent();
            observers = new List<Observer>();
        }

        public void setupGui()
        {
            CurrentConditionDisplay current = new CurrentConditionDisplay(this);
            current.Show();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].update(temp, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float temp = float.Parse(TextBox.Text);
            float humidity = float.Parse(TextBox1.Text);
            float pressure = float.Parse(TextBox2.Text);

            SetMeasurements(temp, humidity, pressure);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             setupGui();
        }
    }
}
