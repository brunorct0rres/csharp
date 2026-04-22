using System.Globalization;

namespace ExerciseNine
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRoomsAvailable = 10;
            int roomsToBeRentedQuantity = 0;

            Console.Write("How many rooms will be rented? ");
            roomsToBeRentedQuantity = int.Parse(Console.ReadLine());

            while (roomsToBeRentedQuantity > maxRoomsAvailable)
            {
                Console.Write($"Max {maxRoomsAvailable} rooms can be rented. Try again: ");
                roomsToBeRentedQuantity = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Lodger lodger;
            Rent rent;
            Rent[] rents = new Rent[maxRoomsAvailable];


            for (int i = 0; i < roomsToBeRentedQuantity; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();

                lodger = new Lodger(name, email);
                rent = new Rent(room, lodger);

                rents[room] = rent;
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < rents.Length; i++)
            {
                if (rents[i] != null) Console.WriteLine(rents[i]);
            }
        }
    }
}
