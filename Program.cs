using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class student
    {
        private string name;
        private string address;
        private int mark;
        public string Name
        {
            get { return name; }
            set { name = value; }


        }
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }



    }
    internal class Program
    {

        static void Main(string[] args)
        {
            student s = new student();
            s.Name = "ahmed";
            s.Address = "iraq/baghdad";
            s.Mark = 100;
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Address);
            Console.WriteLine(s.Mark);
            Console.ReadKey();


        }
    }
}
