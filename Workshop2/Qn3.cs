using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.RV.LIB;

namespace Workshop2
{
    public class Dice
    {
        //attributes
        int Faceup;
        Random r = new Random();

        //Properties
        public string StrFaceUp()
        {
            string A = Convert.ToString(Faceup);
            return A ;
        }

        public int GetFace()
        {
            return Faceup;
        }

        //Constructors
        public Dice()
        {
            Throw();
        }
        
        //Methods
        public void Throw()
        {
            Faceup = r.Next(1, 7);
        }
        
    }

    class Qn3
    {
        static void Main()
        {
            int throwtimes = 10000000; // throwtimes refers to number of times a dice is thrown
            Dice D1 = new Dice();
            Dice D2 = new Dice();
            int hit = 0;
            double prob;

            // throw two dices
            for (int i = 0; i < throwtimes; i++)
            {
                D1.Throw();
                D2.Throw();
                if (D1.GetFace()+D2.GetFace() == 8)
                {
                    hit++;
                }
            }

            // calculate prob of x throws and print
            prob = Convert.ToDouble(hit) / Convert.ToDouble(throwtimes);
            Console.WriteLine(prob);

        }
    }
}
