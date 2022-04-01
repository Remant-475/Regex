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
                Console.WriteLine("Choose 5 : Password for Rule 1");
                 Console.WriteLine("Choose 6 : Password for Rule 2");

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
                    case 5:
                        Console.WriteLine("Enter the Password");
                        string Password_1 = Console.ReadLine();
                        validitation.ValidPasswordRule_1(Password_1);
                        break;
                case 6:
                    Console.WriteLine("Enter the Password");
                    string Password_2 = Console.ReadLine();
                    validitation.ValidPasswordRule_2(Password_2);
                    break;

            } 
        }     
    }
}

