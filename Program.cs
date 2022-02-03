using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_demo
{
    class encap_Demo1
    {
        private int bal, acc_no;
        public string name, B_name;
        int choice,amt;
        char ans;
        public int BAL
        {
            get 
            {
                return bal;
            }
            set 
            {
                bal = value;
            }
        }
        public int ACC_NO
        {
            get
            {
                return acc_no;
            }
            set
            {
                acc_no = value;
            }
        }
        public void accept()
        {
            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Bank Name:");
            B_name = Console.ReadLine();
            Console.WriteLine("Enter the Account Number:");
            acc_no=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Balance :");
            bal = int.Parse(Console.ReadLine());
        }
        public void transaction()
        {
            do
            {
                Console.WriteLine("Entre your choice:\n1:Debit \n2:Credit");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your amount");
                amt = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        bal = bal - amt;
                        break;
                    case 2:
                        bal = bal + amt;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do want to perform any another transaction");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans=='Y'||ans=='y');
        }
    }
}namespace Encapsulation_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.process();
            Console.ReadKey();
        }
        public void process()
        {
            encap_Demo1 obj = new encap_Demo1();
            obj.accept();
            obj.transaction();
            Console.WriteLine("Name:"+obj.name+"\nBank Name:"+obj.B_name+"\nAccount Number"+obj.ACC_NO+"\nBalance is ="+obj.BAL);
        }
    }
}