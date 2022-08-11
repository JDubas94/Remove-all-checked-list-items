using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_all_checked_list_items
{
    class Program
    {
        static int[] Remove(int[] myArray1, int[] myArray2)
        {
            var listArray = myArray1.ToList();

            for (int i = listArray.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < myArray2.Length; j++)
                {

                    if (listArray[i] == myArray2[j])
                    {
                        listArray.RemoveAt(i);
                    }
                }
            }
            
            int[] newArray = listArray.ToArray();

            return newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray1 = new[] { 1, 1, 2, 3, 1, 2, 3, 4 };

            int[] myArray2 = new[] { 1, 3 };

            int[] newArray = Remove(myArray1, myArray2);

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            Console.ReadLine();
        }
    }
}
