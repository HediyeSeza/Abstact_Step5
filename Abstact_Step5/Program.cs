using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstact_Step5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user=new User();
            Console.WriteLine("Please Enter Your Name");
            Console.WriteLine(user.HelloUser(Console.ReadLine()));
            Console.WriteLine("Please Enter Your Family");
            Console.WriteLine(user.FamilyUser(Console.ReadLine()));
            Console.ReadKey();
        }
    }  
    public abstract class MyClass
    {
        public string HelloUser(string name)
        {
            return "Hello " + name;
        }
    }
    public class User : MyClass
    {
        public string FamilyUser(string name)
        {
            return "Your Family is " + name;
        }
    }
    
}
