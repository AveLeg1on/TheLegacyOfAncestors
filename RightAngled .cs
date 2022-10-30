using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegacyOfAncestors
{
    internal class RightAngled : Pair
    {
        private double catit1;
        private double catit2;
        Pair HypeAndS = new Pair();
        public void GetCatit1(double w)
        {
            One = w;
            catit1 =One;
            
        }
        public void GetCatit2(double w)
        {
            Two = w;
          catit2=Two;
        }

        //public double Catit1 { get { return catit1; } set { catit1 = value; } }
        //public double Catit2 { get { return catit2; } set { catit2 = value; } }


        /// <summary>
        /// Считает значение гипотинузы
        /// </summary>
        /// <returns name="HypeAndS.One"></returns>
        public double HypotenuseCalculation()
        {
        
           catit1 = Math.Pow(catit1, 2) * Math.Pow(catit2, 2);

            return Math.Sqrt(catit1);
        }
        /// <summary>
        /// Считает площадь треугольника
        /// </summary>
        /// <returns name="HypeAndS.Two"></returns>
        public double Square()
        {
            catit1 = (catit1 * catit2) / 2;
            return catit1;
        }
       
            

    }
}
