using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{

    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAuthenticate { get; set; }
        public abstract string GetFullName();
        public abstract void Authenticate(string firstname, string lastname);
    }


    public class AuthenticatedUser : User
    {
        public override string GetFullName()
        {
            string fullname = FirstName + " " + LastName;
            return fullname;
        }
        public override void Authenticate(string firstname, string lastname)
        {
            if(FirstName==firstname)
            {
                Console.WriteLine("User authentication");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }


    public class Guest : User
    {
        public override string GetFullName()
        {
            string fullname1 = FirstName + " " + LastName;
            return fullname1;
        }
        public override void Authenticate(string firstname, string lastname)
        {
            if (FirstName == firstname)
            {
                Console.WriteLine("Guest authentication");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the FirstName");
            AuthenticatedUser u = new AuthenticatedUser();
            u.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the LastName");
            u.LastName = Console.ReadLine();
            string fullname = u.GetFullName();
            Console.WriteLine("\nFullName:"+fullname);
            u.Authenticate("vignesh", "pandi");

            Console.WriteLine("\nEnter the FirstName");
            Guest g = new Guest();
            g.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the LastName");
            g.LastName = Console.ReadLine();
            string fullname1 = g.GetFullName();
            Console.WriteLine("\nFullName:" + fullname1);
            g.Authenticate("vicky","pandy");
            Console.ReadLine();
        }
    }
}
