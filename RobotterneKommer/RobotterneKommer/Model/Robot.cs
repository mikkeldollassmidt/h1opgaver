using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotterneKommer.Model
{
    internal class Robot
    {
        // Customization options. Attributes.
        private bool _canSweep = true; // Default true. -- Every robot can sweep.
        private bool _isBig = false; // Default false. -- Has wheels. Can sweep. It also has to polish windows OR change tires.
        private bool _polishOrChangeTires = false; // Default false. If true, has RX microchip. And Polishing Windows. If false, has QT microchip. And changes tires.
        private bool _hasWIFI = false; // Default false. -- Every robot can have wifi
        private string _color = "white"; // Default white. -- Can only be changed if not polishwindows, and batteries.

        // Changes value when attributes above changes values.
        private byte _batteryCapacity = 255; // Default capacity 255.
        private decimal _waterTankCapacity = 2.4M; // Default water tank capacity
        private bool _hasWheels = false; // Default false. -- Has to be big, has to polish og change tires.
        private bool _hasBatteries = true; // Default true. -- Cant if polish windows is true.

        // This constructor is for fully customization.
        public Robot(bool canSweep, bool isBig, bool polishOrChangeTires, bool hasWIFI, string color)
        {
            _canSweep = canSweep;
            _isBig = isBig;
            _polishOrChangeTires = polishOrChangeTires;
            _hasWIFI = hasWIFI;
            _color = color;
        }
        // This constructor is for customization without a color.
        public Robot(bool canSweep, bool isBig, bool polishOrChangeTires, bool hasWIFI)
        {
            _canSweep = canSweep;
            _isBig = isBig;
            _polishOrChangeTires = polishOrChangeTires;
            _hasWIFI = hasWIFI;
        }

        public string Color
        {
            get { return _color; }
            private set { _color = value; }
        }
    }
}
