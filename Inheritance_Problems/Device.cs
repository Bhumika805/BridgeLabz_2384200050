using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Superclass: Device
    class Device
    {
        public string DeviceId { get; set; }
        public string Status { get; set; }

        public Device(string deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}");
            Console.WriteLine($"Status: {Status}");
        }
    }

    // Subclass: Thermostat (Single Inheritance from Device)
    class Thermostat : Device
    {
        public double TemperatureSetting { get; set; }

        public Thermostat(string deviceId, string status, double temperatureSetting)
            : base(deviceId, status)
        {
            TemperatureSetting = temperatureSetting;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine("Thermostat Details:");
            Console.WriteLine($"Device ID: {DeviceId}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
            Console.WriteLine("---------------------------");
        }
    }
}

