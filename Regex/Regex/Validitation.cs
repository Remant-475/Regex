using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexassignment
{
    internal class Validitation
    {
        public Regex FirstnameRegex = new Regex (@"^[A-Z][A-Z a-z]{2,}$");
        public Regex LastnameRegex = new Regex(@"^[A-Z][A-Z a-z]{2,}$");
        public Regex EmailRegex = new Regex(@"^[A-z a-z]+([.+-][A-Z a-z 0-9]+)*@[A-Z a-z 0-9]+.[A-Z a-z]([.[A-z a-z]{2,})?$");
        public void ValidFirstName(string firstname)
        {
            Console.WriteLine("\nFirst Name:" +firstname);
            if (FirstnameRegex.IsMatch (firstname))
            {
                Console.WriteLine("First name is valid");
            }
            else
            {
                Console.WriteLine("Firstname is invalid");
             }
        }
        public void VaidLastName(string lastname)
        {
            Console.WriteLine("\nLast Name:" + lastname);
            if (LastnameRegex.IsMatch(lastname))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is invalid");
            }
        }
        public void Validemail(string email)
        {
            Console.WriteLine("Email :"+email);
            if (EmailRegex.IsMatch(email))
                Console.WriteLine("email is valid");
            else
                Console.WriteLine("email is invalid");
        }
       
    }
}

    

