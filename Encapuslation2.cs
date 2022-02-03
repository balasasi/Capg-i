using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            encap_Demo obj = new encap_Demo();
            obj.PIN = 111;
            obj.PASS = "ABCD";
            Console.WriteLine($"The pin no is{obj.PIN} and Password is {obj.PASS} ");
           // Console.WriteLine("The pi is ="+obj.PIN);
           // Console.WriteLine("The pin value is ={0}",obj.PIN);
            Console.ReadKey();
        }
    }
}
namespace Encapsulation1_demo
{
    class encap_Demo
    {
        //Private variable Declaration
        private int pin_no;
        private string pass;
        //set and get method
        public int PIN
        {
            get
            {
                return pin_no;
            }
            set 
            {
                pin_no = value;
            }
        }
        public string PASS
        {
            get 
            {
                return pass;
            }
            set 
            {
                pass = value;
            }
        }
    }
}