using ElevatorProgram.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProgram.Model
{
    public class Floor
    {
        public int? FloorNumber { get; set; }
        public event EventHandler<ButtonPressedEventArgs> ButtonPressed;
        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
        }
        protected virtual void OnButtonPressed(ButtonPressedEventArgs e)
        {
            if (ButtonPressed != null) ButtonPressed(this, e);
        }
        public void PressElevatorButton(int floorNumber)
        {
            OnButtonPressed(new ButtonPressedEventArgs(floorNumber));
        }
    }
}
