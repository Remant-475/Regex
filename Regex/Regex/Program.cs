using System;

namespace Regexassignment
{
    class UserRegistration
    {
        public static void Main(string[]args)
        {
            Validitation validitation = new Validitation();
            Console.WriteLine("Enter the FirstName");
            string firstname=Console.ReadLine();
            validitation.ValidFirstName(firstname);
            Console.WriteLine("Enter the LastName");
            string lastname = Console.ReadLine();
            validitation.ValidFirstName(lastname);
        }
    }
}

