using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseA
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintAsteriskB(4);
            String[] array = ArrayAsteriskB(6);
            foreach(String str in array) {
                Console.WriteLine(str);
            }

            Console.Read();
        }

        public static String[] ArrayAsterisk(int n) {
            String[] resultArrayAsterisk = new String[n];
            for (int index = 0; index < n; index++) {
                resultArrayAsterisk[index] = new String('*', index + 1);
            }
            return resultArrayAsterisk;
        }
        public static String[] ArrayAsteriskB(int n){
            String[] resultArrayAsterisk = ArrayAsterisk(n);
            for (int index = 0; index < n; index++)
            {
                resultArrayAsterisk[index] += new String('*', index);

            }
            return AddWhiteSpaces(resultArrayAsterisk);
        }

       private static String[] AddWhiteSpaces(String[] AsteriskList)
        {
            int increment = 0;
            for (int index = AsteriskList.Length-1; index > -1; index--)
            {
                AsteriskList[index] = new String(' ', increment) + AsteriskList[index];
                increment++;
            }
            return AsteriskList;
        }
    }
}
