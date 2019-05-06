using ElevatorProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProgram
{
    public class Program
    {
        private const int NO_OF_FLOORS = 12;
        private const int NO_OF_ELEVATORS = 12;
        private const int TRAVEL_TIME_BETWEEN_FLOOR = 3;//in sec
        private Floor[] Floors { get; set; }

        public void Simulate()
        {
            Building building = new Building(NO_OF_FLOORS, NO_OF_ELEVATORS, TRAVEL_TIME_BETWEEN_FLOOR);
            building.StartElevators();
            Floors = building.Floors;
            //4 th floor Elevator button pressed
            Floors[3].PressElevatorButton(3);
        }
    }
}
