using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftJobAssignment
{
    class Program
    {
        static int[] myArray = { 1, 4, 6, 2, 1, 7, 4, 6, 2, 8 };

        static int FirstUniqIterativ(int[] myArray)
        {
            //Skriv din kode her
            for (int i = 0; i < myArray.Length; i++)
            {
                int tal1 = myArray[i];
                bool foundDublet = false; 
                
                for (int j = 0; j < myArray.Length; j++)
                {
                    int tal2 = myArray[j];
                    if (i != j && tal1 == tal2)
                    {
                        foundDublet = true;
                        break;
                    }
                }
                if (foundDublet == false)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(myArray[FirstUniqIterativ(myArray)]);

            Console.ReadLine();
        }
    }

}
