using System;
using System.Collections.Generic;
using System.IO;

namespace Sorting_Alogorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DataArray data = new DataArray(@"C:\Users\josep\source\repos\Sorting Alogorithms\Sorting Alogorithms\Data\data.csv");
            data.displayArray();
        }
    }

    class SortAlogirthims
    {
        public List<int> selectionSort(List<Int32> array)
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
        private List<int> array;

        public DataArray()
        {
            //generateRandomData();  TODO create method
        }

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

        public List<int> getDataArray()
        {
            return this.array;
        }

        public void setDataArray(List<int> array)
        {
            this.array = array;
        }
    }



    /*class DataHandler
    {
        private List<int> dataArray;

        public DataHandler(String filePath)
        {
            dataArray = loadData(filePath);
            displayArray(dataArray);

            SortAlogirthims sorter = new SortAlogirthims();

            dataArray = 
        }

        private List<int> loadData(string filePath)
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

        public static void displayArray(List<int> array)
        {
            foreach (var line in array)
            {
                Console.WriteLine(line.ToString());
            }
        }

        class SortAlogirthims
        {
            public static List<int> selectionSort(List<Int32> array)
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

            public static List<int> Swap(List<int> array, int first, int second)
            {
                int temp = array[first];
                array[first] = array[second];
                array[second] = temp;
                return array;
            }
        }
    }*/
}
