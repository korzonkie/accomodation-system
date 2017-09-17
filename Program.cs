using System;

namespace accomodation_system
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel("Hotel1", 3, 2);

            var person = new Person("Maciej", "Korzeniewski");
            var roomIdentifier = new RoomIdentifier()
            {
                FloorNumber = 1,
                RoomNumber = 1
            };
            
            hotel.AssignPersonToRoom(person, roomIdentifier);
        }
    }
}
