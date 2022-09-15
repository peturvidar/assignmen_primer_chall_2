using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{
    internal class Weather
    {

        public Weather(double temp, double humid, string sca)
        {
            Scale = sca;
            Temperature = temp;
            Humidity = humid;
        }
        private string _Scale;
        public string Scale
        {
            get
            {
                return _Scale;

            }

            set
            {
                if (value.ToUpper() == "C" || value.ToUpper() == "F")
                {
                    _Scale = value;
                }
                else
                {
                    throw new Exception("Not a valid scale value");
                }
            }
        }
        private double _Temperature;
        public double Temperature
        {
            get
            {
                return _Temperature;
            }
            set
            {
                if (_Scale == "C")
                {
                    if (value >= -60 && value <= 60)
                    {
                        _Temperature = value;
                    }
                    else
                    {
                        throw new Exception("This is not a valid temperature value");
                    }
                }
                else if (_Scale == "F")
                    if (value >= -76 && value <= 140)
                    {
                        _Temperature = value;
                    }
                    else
                    {
                        
                        throw new Exception("This is not a valid temperature value");
                    }

            }

        }
        private double _Humidity;
        public double Humidity
        {
            get
            {
                return _Humidity;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _Humidity = value;
                }
                else
                {
                    throw new Exception("This is not a valid number please select from 0-100");
                }
            }
        }
        public void Convert()
        {
            if(Scale == "C")
            {
                double newTemp = (Temperature = 9 / 5) + 32;
                Scale = "F";
                Temperature = newTemp;
            }
            else if (Scale == "F")
            {
                double newTemp = (Temperature -32) * 5 / 9;
                Scale = "C";
                Temperature = newTemp;
            }
        }
    }
}
