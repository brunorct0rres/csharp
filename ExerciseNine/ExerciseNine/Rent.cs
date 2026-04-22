namespace ExerciseNine
{
    class Rent
    {
        public int RoomNumber { get; set; }
        public Lodger Lodger { get; set; }

        public Rent(int roomNumber, Lodger lodger)
        {
            RoomNumber = roomNumber;
            Lodger = lodger;
        }

        public override string ToString()
        {
            return $"{RoomNumber}: {Lodger.Name}, {Lodger.Email}";
        }
    }
}