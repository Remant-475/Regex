using System;

namespace Regexassignment
{
    class UserRegistration
    {
        public static void Main(string[] args)
        {
            Validitation validitation = new Validitation();
            int option = 0;
            
                Console.WriteLine("Choose 1 : First Name");
                Console.WriteLine("Choose 2 : Last Name");
                Console.WriteLine("Choose 3 : Email");
                Console.WriteLine("Choose 4 : PhoneNumber");

            Console.WriteLine("Enter Your Choice");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the FirstName");
                        string firstname = Console.ReadLine();
                        validitation.ValidFirstName(firstname);
                        break;
                    case 2:
                        Console.WriteLine("Enter the LastName");
                        string lastname = Console.ReadLine();
                        validitation.VaidLastName(lastname);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Email");
                        string email = Console.ReadLine();
                        validitation.Validemail(email);
                        break;
                    case 4:
                      Console.WriteLine("Enter the PhoneNumber");
                     string phonenumber = Console.ReadLine();
                       validitation.ValidPhoneNumber(phonenumber);
                        break;

            } 
        }     
    }
}

