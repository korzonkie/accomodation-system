using System;
using System.Collections.Generic;
using System.Linq;

namespace accomodation_system
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Person> Residents { get; set; }

        public Hotel(string hotelName, int numberOfFloors, int numberOfRoomsAtOneFloor)
        {
            HotelName = hotelName;
            Residents = new List<Person>();
            Rooms = GenerateRooms(numberOfFloors, numberOfRoomsAtOneFloor);
        }

        private List<Person> GenerateResidents(int numberOfResidents)
        {
            var residents = new List<Person>(numberOfResidents);

            for (int i = 0; i < numberOfResidents; i++)
            {
                var person = new Person($"FirstName_{i + 1}", $"LastName_{i + 1}");
                residents.Add(person);
            }

            return residents;
        }

        private List<Room> GenerateRooms(int numberOfFloors, int numberOfRoomsAtOneFloor)
        {
            var rooms = new List<Room>(numberOfFloors * numberOfRoomsAtOneFloor);

            for (int currentFloor = 0; currentFloor < numberOfFloors; currentFloor++)
            {
                for (int currentRoom = 0; currentRoom < numberOfRoomsAtOneFloor; currentRoom++)
                {
                    var room = new Room(currentFloor, currentRoom);
                    rooms.Add(room);
                }
            }

            return rooms;
        }

        public void AssignPersonToRoom(Person person, RoomIdentifier roomIdentifier)
        {
            Residents.Add(person);

            var chosenRoom = Rooms
                .Where(room => room.RoomIdentifier.FloorNumber == roomIdentifier.FloorNumber && room.RoomIdentifier.RoomNumber == roomIdentifier.RoomNumber)
                .FirstOrDefault();

            if (chosenRoom == null)
            {
                throw new InvalidOperationException("Nie takiego pokoju.");
            }

            chosenRoom.RentRoom(person);
        }
    }
}