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
        public Regex PhoneRegex = new Regex(@"^[]0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRule_1 = new Regex(@"^[A-Z a-z]{8,}$");
        public Regex PasswordRule_2 = new Regex(@"^(?=.*[A-Z])[A-Z a-z]{8,}$");
        public Regex PasswordRule_3 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])[A-Z a-z 0-9]{8,}$");
        public Regex PasswordRule_4 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9]{8,}$");



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
        public void ValidPhoneNumber(string phonenumber)
        {
            Console.WriteLine("PhoneNumber :" + phonenumber);
            if (PhoneRegex.IsMatch(phonenumber))
                Console.WriteLine("PhoneNumber is valid");
            else
                Console.WriteLine("PhoneNumber is invalid");
        }
        public void ValidPasswordRule_1(string Password_1)
        {
            Console.WriteLine("Password :" + Password_1);
            if (PasswordRule_1.IsMatch(Password_1))
                Console.WriteLine("Password  is valid");
            else
                Console.WriteLine("Password is invalid");
        }
        public void ValidPasswordRule_2(string Password_2)
        {
            Console.WriteLine("Password :" + Password_2);
            if (PasswordRule_2.IsMatch(Password_2))
                Console.WriteLine("Password  is valid");
            else
                Console.WriteLine("Password is invalid");
        }
        public void ValidPasswordRule_3(string Password_3)
        {
            Console.WriteLine("Password :" + Password_3);
            if (PasswordRule_3.IsMatch(Password_3))
                Console.WriteLine("Password  is valid");
            else
                Console.WriteLine("Password is invalid");
        }
        public void ValidPasswordRule_4(string Password_4)
        {
            Console.WriteLine("Password :" + Password_4);
            if (PasswordRule_4.IsMatch(Password_4))
                Console.WriteLine("Password  is valid");
            else
                Console.WriteLine("Password is invalid");
        }

    }
}

    

