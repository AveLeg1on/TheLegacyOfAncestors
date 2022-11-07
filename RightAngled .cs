using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegacyOfAncestors
{
    internal class RightAngled : Pair
    {
       private new double one;
        private new double two;
        public new  double One
        {
            get
            {
                return one;
            }
            set
            {
                one = value;
            }

        }
        public new double Two
        {
            get
            {
                return two;
            }
            set
            {
                two = value;
            }

        }

        /// <summary>
        /// Считает значение гипотинузы
        /// </summary>
        /// <returns name="one"></returns>
        public double HypotenuseCalculation()
        {
        
          one = Math.Pow(one, 2) + Math.Pow(two, 2);

            return Math.Sqrt(one);
        }
        /// <summary>
        /// Считает площадь треугольника
        /// </summary>
        /// <returns name="two"></returns>
        public double Square()
        {
            two = (one *two) / 2;
            return two;
        }



    }
}
