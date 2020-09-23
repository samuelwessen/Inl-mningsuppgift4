using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using SharedLibraries.Models;

namespace SharedLibraries.Services
{
    public static class DeviceService
    {
        private static readonly Random rnd = new Random();

        public static async Task SendMessageAsync(DeviceClient deviceClient)
        {
            
            {
                var weatherdata = new TemperatureModel
                {
                    Temperature = rnd.Next(20, 40),
                    Humidity = rnd.Next(25, 55)
                };

                var json = JsonConvert.SerializeObject(weatherdata);
                var payload = new Message(Encoding.UTF8.GetBytes(json));
                await deviceClient.SendEventAsync(payload);


                Console.WriteLine($"Message sent: {json}");
                
            }
        }



    }
}
