using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> EMAILS = new List<string> { "kontsomis@yahoo.com", "kontsomis@hotmail.com", "kontsomis@gmail.com" };
            List<string> PASS = new List<string> { "yahoo", "hotmail", "gmail" };
            List<string> NAMES = new List<string> { "Konstantinos", "Kostas", "Katsos" };
            List<string> SURNAMES = new List<string> { "Tsomis1", "Tsomis2", "Tsomis3" };
            List<string> BIRTHDAYS = new List<string> { "11/03/1994", "11/03/1994", "11/03/1994" };

            string password;
            bool found = false;
            int flag = 0;

            Console.Write("Please enter your email: ");
            string mail = Console.ReadLine();

            for(int i = 0; i < EMAILS.Count; i++)
            {
                if(EMAILS[i] == mail)
                {
                    flag = i;
                    do
                    {
                        Console.Write("Please enter your password: ");
                        password = Console.ReadLine();
                        if(PASS[flag] == password)
                        {
                            found = true;
                        }
                        if (found == false)
                        {
                            Console.WriteLine("Wrong password");
                        }
                    } while (found != true);
                    Console.WriteLine("\n Login Successful");
                }
            }
            if (found == false)
            {
                Console.WriteLine("Email not found! \n");
                Console.WriteLine("Creating a new account \n");
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();
                NAMES.Add(name);
                Console.Write("Please enter your surname: ");
                string surname = Console.ReadLine();
                SURNAMES.Add(surname);
                Console.Write("Please enter your date of birth: ");
                string birthday = Console.ReadLine();
                BIRTHDAYS.Add(birthday);
                Console.Write("Please enter a new email: ");
                mail = Console.ReadLine();
                EMAILS.Add(mail);
                Console.Write("Please enter a new password: ");
                password = Console.ReadLine();
                PASS.Add(password);
                Console.WriteLine("\n");
                Console.WriteLine($"New account created for {name} {surname}! \n");

                Console.Write("Please enter your email: ");
                mail = Console.ReadLine();

                for (int i = 0; i < EMAILS.Count; i++)
                {
                    if (EMAILS[i] == mail)
                    {
                        flag = i;
                        do
                        {
                            Console.Write("Please enter your password: ");
                            password = Console.ReadLine();
                            if (PASS[flag] == password)
                            {
                                found = true;
                            }
                            if (found == false)
                            {
                                Console.WriteLine("Wrong password");
                            }
                        } while (found != true);
                        Console.WriteLine("\n Login Successful");
                    }
                }
            }

            //Console.WriteLine("Login Successful");
        }
    }
}
