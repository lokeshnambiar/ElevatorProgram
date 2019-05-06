using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ElevatorProgram.Model
{
    public class Building
    {
        public Floor[] Floors { get; set; }
        private int NumberOfElevators { get; set; }
        public Elevator[] Elevators { get; set; }

        public Building(int numberFloors, int numberElevators, int travelTime)
        {
            NumberOfElevators = numberElevators;
            for (int i = 0; i < numberFloors; i++)
            {
                Floors[i] = new Floor(i);
            }
            for (int i = 0; i < NumberOfElevators; i++)
            {
                Elevators[i] = new Elevator("E" + i.ToString(), numberFloors, -2, this, travelTime, - 2);
            }
        }

        public void StartElevators()
        {
            for(int i = 0; i < NumberOfElevators; i++)
            {
                Elevators[i].StartElevator();
            }
        }

        public void StopElevators()
        {
            for (int i = 0; i < NumberOfElevators; i++)
            {
                Elevators[i].StopElevator();
            }
        }
    }
}
