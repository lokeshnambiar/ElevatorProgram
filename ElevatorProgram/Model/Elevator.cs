using ElevatorProgram.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ElevatorProgram.Model
{
    public class Elevator
    {
        private string Name { get; set; }
        private int Capacity { get; set; }
        private int CurrentFloor { get; set; }
        private int DestinationFloor { get; set; }
        private bool UpTransit { get; set; }
        private Building BuildingComplex { get; set; }
        //Time at each floor
        private int FloorServiceTime { get; set; }
        //Time between floor
        private int TravelTime { get; set; }
        //No of passengers on elevator
        private int NumberofPassengers { get; set; }
        //Persons getting off each floor
        //private Person[] Passengers { get; set; }
        //Floors of building
        private Floor[] Floors { get; set; }
        //Number of floors
        private int NumberofFloors { get; set; }
        //Is elevator running
        private bool IsRunning { get; set; }

        public Elevator(string name, int numberOfFloors, int startingFloor, Building complex, int travelTime, int basement)
        {
            Name = name;
            NumberofFloors = numberOfFloors;
            CurrentFloor = CurrentFloor;
            BuildingComplex = complex;
            TravelTime = travelTime;
            Floors = complex.Floors;
            DestinationFloor = basement;
            UpTransit = true;
        }

        private void ListenToButtonPressOnFloors()
        {
            for(int i =0;i< Floors.Count(); i++)
            {
                Floors[i].ButtonPressed += Floor_ButtonPressed;
            }
        }

        /// <summary>
        /// Callback for button press event. This will listen to button press event and will
        /// change its destinationfloor accordingly.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        void Floor_ButtonPressed(Object o, ButtonPressedEventArgs e)
        {
            if (UpTransit)
            {
                if (e.Floor >= DestinationFloor)
                {
                    DestinationFloor = e.Floor;
                }
            }
            else
            {
                if (e.Floor <= DestinationFloor)
                {
                    DestinationFloor = e.Floor;
                }
            }
            if(CurrentFloor != DestinationFloor)
            {
                Run(DestinationFloor);
            }
            
        }
        /// <summary>
        /// Start elevator from running
        /// </summary>
        public void StartElevator()
        {
            IsRunning = true;
        }
        /// <summary>
        /// Stop elevator from running
        /// </summary>
        public void StopElevator()
        {
            IsRunning = false;
        }
        /// <summary>
        /// Run elevator up and down in building, picking and droping passengers.
        /// </summary>
        public void Run(int nextFloor)
        {
            while(IsRunning)
            {
                int floorDiff = Math.Abs(CurrentFloor - nextFloor);
                UpTransit = true;
                if (nextFloor < CurrentFloor) { 
                    UpTransit = false;
                    
                }
              
                //Reaching the destination
                Thread.Sleep(TravelTime * floorDiff);
                IsRunning = false;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
