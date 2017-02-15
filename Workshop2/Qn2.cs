using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Qn2
    {
        static void Main()
        {
            triangle t = new triangle();
            Console.WriteLine(t.Area());
            Console.WriteLine(t.Perimeter());
        }
    }


    public class triangle
    {
        //attributes
        double Base;
        double Height;
        double SideA;
        double SideB;

        //properties
       public double Base2
        {
            get {
                return Base2;
            }

            set
            {
                Base2 = value;
            }
        }

        public double Height2
        {
            get
            {
                return Height2;
            }

            set
            {
                Height2 = value;
            }
        }

        public double SideA2
        {
            get
            {
                return SideA2;
            }

            set
            {
                SideA2 = value;
            }
        }

        public double SideB2
        {
            get
            {
                return SideB2;
            }

            set
            {
                SideB2 = value;
            }
        }

        //constructor
        public triangle() 
        {
            Console.WriteLine("Please enter Base length of triangle");
            string input = Console.ReadLine();
            Base = Convert.ToDouble(input);

            Console.WriteLine("Please enter Height of triangle");
            string input2 = Console.ReadLine();
            Height = Convert.ToDouble(input2);

            Console.WriteLine("Please enter 2nd side of triangle");
            string input3 = Console.ReadLine();
            SideA = Convert.ToDouble(input3);

            Console.WriteLine("Please enter 3rd side of triangle");
            string input4 = Console.ReadLine();
            SideB = Convert.ToDouble(input4);
        }

        //methods
        public double Area()
        {
            return (0.5 * Base * Height);
        }

        public double Perimeter()
        {
            return (Base + SideA + SideB);
        }

    }

}
