namespace accomodation_system
{
    public class Room
    {
        public RoomIdentifier RoomIdentifier { get; set; }
        public bool IsRented { get; set; }
        public Person Renter { get; set; }

        public Room(int floor, int roomNumber)
        {
            var roomIdentifier = new RoomIdentifier()
            {
                FloorNumber = floor,
                RoomNumber = roomNumber
            };

            RoomIdentifier = roomIdentifier;
        }

        public void RentRoom(Person person)
        {
            Renter = person;
            IsRented = true;
        }
    }
}