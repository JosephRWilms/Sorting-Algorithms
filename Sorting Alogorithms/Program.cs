using System;
using System.Collections.Generic;
using System.IO;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DataArray data = new DataArray(@"C:\Users\josep\source\repos\Sorting Algorithms\Sorting Algorithms\Data\data.csv");
            data.displayArray();

            SortAlgirthims sorter = new SortAlgirthims(); //Really want to make this static

            data.array = sorter.insertSort(data.array);
            data.displayArray();
        }
    }

    class SortAlgirthims
    {
        public List<int> selectionSort(List<int> array)
        {
            int smallest;
            for (int i = 0; i < array.Count - 1; i++)
            {
                smallest = i;
                for (int index = i + 1; index < array.Count; index++)
                {
                    if (array[index] < array[smallest])
                    {
                        smallest = index;
                    }
                }
                array = Swap(array, i, smallest);
            }

            return array;
        }

        public List<int> insertSort(List<int> array)
        {
            int size = array.Count;
            for (int index = 1; index < size; index++)
            {
                int key = array[index];
                int scan = index - 1;
                while(scan >= 0 && array[scan] > key)
                {
                    array[scan + 1] = array[scan];
                    scan = scan - 1;
                }
                array[scan + 1] = key;
            }

            return array;
        }

        public static List<int> Swap(List<int> array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
            return array;
        }
    }

    class DataArray
    {
        public List<int> array;

        /*public DataArray()
        {
            //generateRandomData();  TODO create method
        }*/

        public DataArray(string filePath)
        {
            array = new List<int>();
            array = loadDataFromFile(filePath);
        }

        private List<int> loadDataFromFile(string filePath)
        {
            var tempDataArray = new List<int>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    tempDataArray.Add(Int32.Parse(reader.ReadLine()));
                }
            }
            return tempDataArray;
        }

        public void displayArray()
        {
            foreach (var line in array)
            {
                Console.WriteLine(line.ToString());
            }
        }
    }
}