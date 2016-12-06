using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP287Kaprekars
{
    class Kaprekars
    {
        public Kaprekars()
        {

        }

        //find the largest digit in a number
        public int LargestDigit(int number)
        {
            char[] charArray = GetCharArray(number);
            int largest = 0;
            foreach(char c in charArray)
            {
                if (int.Parse(char.ToString(c)) > largest)
                    largest = int.Parse(char.ToString(c));
            }
            return largest;
        }

        //sort the digits in a number to be descending, if asc is passed as true, then output acsending order
        public int SortDigits(int number, bool asc = false)
        {
            string numberStr = number.ToString();
            while(numberStr.Length < 4)
            {
                numberStr += "0";
            }
            if (asc)
                return int.Parse(new string(numberStr.OrderBy(i => i).ToArray()));
            else
                return int.Parse(new string(numberStr.OrderByDescending(i => i).ToArray()));
        }


        public int KaprekarRoutine(int number)
        {
            string numString = number.ToString();
            HashSet<char> charSet = new HashSet<char>();
            foreach(char c in numString)
            {
                charSet.Add(c);
            }
            if(charSet.Count < 2)
                return -1;
            return KaprekarMethod(number, 0);
        }

        public int KaprekarMethod(int number, int counter)
        {
            if (number == 6174 )
                return counter;
            else
            {
                //put the actual logic here
                int ascOrder = SortDigits(number, true);
                int descOrder = SortDigits(number);

                number = descOrder - ascOrder;
                return KaprekarMethod(number, ++counter);
            }
                
        }


        //take an int, and get the digits as chars in an array.
        private char[] GetCharArray(int number)
        {
            return number.ToString().ToCharArray();
        }
    }
}
