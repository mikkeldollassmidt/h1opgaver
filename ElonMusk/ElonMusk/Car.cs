using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElonMusk
{
    public class Car
    {
        // Creating attributes
        private byte _batteryCapacity = 100;
        private string _color = "(Set color)";
        private int _metresDriven = 0;

        // Creating properties
        public byte BatteryCapacity
        {
            get { return _batteryCapacity; }
            private set { _batteryCapacity = value; }
        }
        public string Color
        {
            get { return _color; }
            private set { _color = value; }
        }
        public int MetresDriven
        {
            get { return _metresDriven; }
            private set { _metresDriven = value; }
        }
        // Method for choosing color.
        public void ColorChoose()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    _color = "Red";
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    _color = "Yellow";
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    _color = "Green";
                    break;
                default:
                    Console.Clear();
                    _color = "Red";
                    break;
            }
        }
        // Method for displaying information about car 1 and car 2.
        public void Display()
        {
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Battery: " + BatteryCapacity + "%");
            Console.WriteLine("Metres driven: " + MetresDriven + "\r\n");
        }
        // Runs cars
        public void Run()
        {

            if (_batteryCapacity>=1)
            {
                _metresDriven += 20;
                _batteryCapacity -= 1;
            }
            else
            {
                NeedChargeMessage();
            }
        }
        // Charge car method
        public void ChargeCar()
        {
            if (_batteryCapacity<=100)
            {
                _batteryCapacity = 100;
            }
            else
            {
                Console.WriteLine("Can't charge.");
            }
        }
        // Writing a needs charging message.
        public void NeedChargeMessage()
        {
            Console.WriteLine("Battery is too low.");
            Thread.Sleep(1000);
        }
    }
}
