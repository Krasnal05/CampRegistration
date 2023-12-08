using System;

namespace CampRegistration
{
    class Program
    {
        //Stała
        public const string FILE_NAME = @"C:\CampRegistrationFiles\ImportFile.xlsx";
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to our registration!");
            Console.WriteLine("You can choose one of the roles you'll have at camp");
            Console.WriteLine("1. Organizer");
            Console.WriteLine("2. Camp counselor");
            Console.WriteLine("3. Participant");
            Console.WriteLine("4. Parent");
            Console.WriteLine("Press 1, 2, 3, or 4");

            string choise = Console.ReadLine();
            Console.WriteLine($"You have chosen option number: {choise}");
            int chosenOption;
            Int32.TryParse(choise, out chosenOption);

            while ((chosenOption < 1)||(chosenOption > 4))
            {
                Console.WriteLine("You would had to choose wrong number, please try again");
                choise = Console.ReadLine();
                Console.WriteLine($"You have chosen option number: {choise}");
                Int32.TryParse(choise, out chosenOption);
            }
        }
    }
}