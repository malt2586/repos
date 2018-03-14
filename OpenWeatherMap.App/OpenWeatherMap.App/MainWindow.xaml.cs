using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using APIAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<City> cityIDList; 
        private APIHandler apiHandler;
        private RootObject owmForecast;
        private int currentTimeSegment = 0;

        public MainWindow()
        {
            InitializeComponent();

            apiHandler = new APIHandler();
            GetCityIDList();
        }

        private void btn_GetForecast_Click(object sender, RoutedEventArgs e)
        {
            cityIDList.ForEach(
                delegate (City city)
                {
                    if (city.name.Equals(tbx_City.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        owmForecast = apiHandler.GetForecast(city.id.ToString());
                        SetInfoBoxValues(currentTimeSegment);
                        return;
                    }
                });
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            if (currentTimeSegment < owmForecast.list.Count - 1)
            {
                currentTimeSegment++;
                SetInfoBoxValues(currentTimeSegment);
            }
        }

        private void btn_Prev_Click(object sender, RoutedEventArgs e)
        {
            if (currentTimeSegment > 0)
            {
                currentTimeSegment--;
                SetInfoBoxValues(currentTimeSegment);
            }
        }

        private void SetInfoBoxValues(int listNum)
        {
            lbl_DateTime.Content = owmForecast.list[listNum].dt_txt;
            lbl_Temp.Content = owmForecast.list[listNum].main.temp;
            lbl_Pressure.Content = owmForecast.list[listNum].main.pressure;
            lbl_Humidity.Content = owmForecast.list[listNum].main.humidity;
            lbl_Clouds.Content = owmForecast.list[listNum].clouds.all;
            lbl_WindSpeed.Content = owmForecast.list[listNum].wind.speed;
            lbl_WindDirection.Content = owmForecast.list[listNum].wind.deg;
            if (owmForecast.list[listNum].rain == null)
            {
                lbl_Rain.Content = 0;
            }
            else
            {
                lbl_Rain.Content = owmForecast.list[listNum].rain.rainThreeHours;
            }
            if (owmForecast.list[listNum].snow == null)
            {
                lbl_Snow.Content = 0;
            }
            else
            {
                lbl_Snow.Content = owmForecast.list[listNum].snow.snowThreeHours;
            }
        }

        private void GetCityIDList()
        {
            using (StreamReader file = File.OpenText(@"C:\Users\malt2586\source\repos\OpenWeatherMap.App\city.list.json"))
            {
                cityIDList = JsonConvert.DeserializeObject<List<City>>(file.ReadToEnd());
            }
        }
    }
}
