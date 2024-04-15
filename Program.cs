using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();

            house.Doors.Add(houseDoor); 
            room.Doors.Add(roomDoor);
            house.Rooms.Add(room);
        }
    }

    public class House
    {
        public List<Room> Rooms { get => []; }
        public List<Door> Doors { get => []; }
    }

    public class Room
    {
        public List<Door> Doors { get => []; }
    }

    public class Door
    {
        private bool _isOpen;

        public bool IsOpen
        {
            get => _isOpen;
            set
            {
                if (IsOpen && value)
                    Console.WriteLine("Door already opened. Ain't done anything.");
                else if (!IsOpen && !value)
                    Console.WriteLine("Door already closed. Ain't done anything.");
                else _isOpen = value;
            }
        }
    }
}