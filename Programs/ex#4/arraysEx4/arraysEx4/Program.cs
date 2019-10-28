using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            // array[n]

            // INPUT:
            // array length:
            // 8
            // numbers from array:
            // 1
            // 2
            // 3
            // 4
            // 3
            // 8
            // 3
            // 2
            //
            // OUTPUT:
            // unique
            // 1
            // 4
            // 8
            // not unique
            // 2 - 2
            // 3 - 3

            Console.WriteLine("Array length");
            // The number of the elements that will
            // be stored in the array
            int arrayLength = int.Parse(Console.ReadLine());

            // Numbers entered from the console
            int[] array = new int[arrayLength];

            // Array where the unique numbers will be stored
            // unique - those numbers which appear in the 
            // array only once
            int[] unique = new int[arrayLength];
            // Counter for the index of the next unique element
            int uniqueCounter = 0;

            // Array where the non-unique numbers will be stored
            // like a couple with count of the times they appear
            // in the array
            int[,] notUnique = new int[arrayLength, 2];
            // Counter for the index of the next non-unique element
            int notUniqueCounter = 0;

            // Setting the values for the numbers in the array
            for(int i = 0; i < array.Length; i++)
            {
                // i is the index of the current element
                // (the one that we are currently setting
                // the value of)
                Console.WriteLine($"Element {i}:");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Going through each element of the array
            // checking if it is equal to every other 
            // element from the array
            for(int i = 0; i < array.Length; i++)
            {
                // Setting the value of the counter
                // for how many times the item is duplicated
                // in the array to 1 for every item
                // so that we start counting from 1
                int duplicatesTimes = 1;
                // Bool value representing if the
                // value of the element appears in 
                // the array before the current element
                bool duplicatesBeforeCurrentElement = false;

                // Going through each element of the array
                // to check if it is equal to the current one
                for (int j = 0; j < array.Length; j++)
                {
                    // j != i prevents from checking
                    // if the current element is equal to
                    // itself
                    if (j != i && array[i] == array[j])
                    {
                        // If the checked item is equal to
                        // the current one we increase the
                        // counter (how many times the item
                        // appears in the array) by one
                        duplicatesTimes++;
                        if(i<j)
                        {
                            // If we have already gone trough
                            // the element it is already added
                            // to the notUnique array so there
                            // is no point in adding it again or
                            // counting again how many times it
                            // appears in the array
                            duplicatesBeforeCurrentElement = true;
                            break;
                        }
                    }
                }
                // Checking if the element already exists in
                // the notUnique array
                if (!duplicatesBeforeCurrentElement)
                {
                    // Adding the element to the correct array
                    // depending on how many times it appears
                    // in the array
                    if (duplicatesTimes == 1)
                    {
                        unique[uniqueCounter] = array[i];
                        uniqueCounter++;
                    }
                    else
                    {
                        notUnique[notUniqueCounter, 0] = array[i];
                        notUnique[notUniqueCounter, 1] = duplicatesTimes;
                        notUniqueCounter++;
                    }
                }
            }

            // Printing the unique array or showing a
            // default message if there are no unique elements
            Console.WriteLine("Unique:");
            if (uniqueCounter == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < uniqueCounter; i++)
                {
                    Console.WriteLine(unique[i]);
                }
            }

            // Printing the notUnique array or showing a
            // default message if there are no non-unique elements
            Console.WriteLine("Not unique:");
            if(notUniqueCounter == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for(int i=0;i<notUniqueCounter;i++)
                {
                    Console.WriteLine($"{notUnique[i,0]} - {notUnique[i, 1]}");
                }
            }

            // For any further questions please contact me :)
        }
    }
}
