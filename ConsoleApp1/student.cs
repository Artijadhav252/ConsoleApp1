using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public string Address { get; set; }
      //  public int ContactNumber { get; set; }
        public int sub1Marks { get; set; }
        public int sub2Marks { get; set; }
        public int sub3Marks { get; set; }
        public int TotalMarks { get; set; }
      


        public void getdata()
        {
            Console.WriteLine("Please enter the value for Id");
            Id= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for Name");
            Name = Convert.ToString(Console.ReadLine());

            // Console.WriteLine("Please enter the value for Address");
            // Address = Convert.ToString(Console.ReadLine());

            // Console.WriteLine("Please enter the value for ContactNumber");
            //ContactNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter sub1marks");
            sub1Marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter sub2marks");
            sub2Marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter sub3marks");
            sub3Marks = Convert.ToInt32(Console.ReadLine());

            TotalMarks = totalmarks();

        }
        public void putdata()
        {
            Console.WriteLine("Id="+Id);
            Console.WriteLine("Name="+Name);
            //Console.WriteLine("Address="+Address);
            //Console.WriteLine("ContactNumber="+ContactNumber);
            Console.WriteLine("sub1Marks="+ sub1Marks);
            Console.WriteLine("sub2Marks="+ sub2Marks);
            Console.WriteLine("sub3Marks="+ sub3Marks);
            Console.WriteLine("TotalMarks="+TotalMarks);
        }

        public   int totalmarks ()
        {
            int TotalMarks = sub1Marks + sub2Marks + sub3Marks;
            return TotalMarks;
        }
    }
}
