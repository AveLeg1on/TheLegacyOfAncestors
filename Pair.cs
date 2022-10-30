﻿namespace TheLegacyOfAncestors
{
    internal class Pair
    {
        protected double  one;
      protected double two;
        public double One 
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
        public double Two 
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
        /// 
        /// </summary>
        /// <param name="firstPair" name="secondPair"></param>
        /// <returns name="firstPair"></returns>
        public Pair Multiplication(Pair firstPair, Pair secondPair, Pair result)
        {

            result.One = firstPair.One * secondPair.One;
            result.Two = firstPair.Two * secondPair.Two;
            return result;
        }

        public static Pair operator *(Pair firstPair, Pair secondPair)
        {
            Pair result = new Pair();
            result.One = firstPair.One * secondPair.One;
            result.Two = firstPair.Two * secondPair.Two;
            return result;
        }
        public static Pair operator ++(Pair firstpair)
        {
            Pair result = new Pair();
            result.One = firstpair.One*2;
            result.Two = firstpair.Two*2;

            return result;
        }

        /// <summary>
        /// Умножает пары чисел
        /// </summary>
        /// <returns name="firstPair"></returns>
        public Pair Multiplication(Pair firstpair, Pair result)
        {

            result.One = firstpair.One * 2;
            result.Two = firstpair.Two * 2;

            return result;
        }
       
    }
}
