using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProgram.Data
{
    public class ButtonPressedEventArgs : EventArgs
    {
        public readonly int Floor;
        public ButtonPressedEventArgs(int floor)
        {
            Floor = floor;
        }
    }
}
