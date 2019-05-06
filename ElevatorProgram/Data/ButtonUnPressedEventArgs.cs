using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProgram.Data
{
    public class ButtonUnPressedEventArgs : EventArgs
    {
        public readonly int Floor;
        public ButtonUnPressedEventArgs(int floor)
        {
            Floor = floor;
        }
    }
}
