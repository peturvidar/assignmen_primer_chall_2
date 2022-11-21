using WeatherData;
using static System.Formats.Asn1.AsnWriter;



Weather weather = new(15, 75, "C");




Console.WriteLine($"Temperature: {weather.Temperature} Humidity: {weather.Humidity} scale: {weather.Scale} ");
weather.Convert();


