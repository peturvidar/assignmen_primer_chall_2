using static System.Formats.Asn1.AsnWriter;

namespace WeatherData
{
    class Program
            {
    
        
        static void Main(string[] args)
        {

            Weather weather = new Weather(100, 75, "C");
            



            Console.WriteLine($"Temperature: {weather.Temperature} Humidity: {weather.Humidity} scale: {weather.Scale} ");
            weather.Convert();
        }
    }
}


