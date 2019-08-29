using System;
using System.Collections.Generic;
using System.IO;

namespace Sorting_Alogorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            String filePath = @"C:\Users\josep\source\repos\Sorting Alogorithms\Sorting Alogorithms\Data\data.csv";

            DataHandler dataHandler = new DataHandler(filePath);
        }
    }

    class DataHandler
    {
        private List<int> dataArray;

        public DataHandler(String filePath)
        {
            dataArray = loadData(filePath);
            displayArray(dataArray);
        }

        private List<int> loadData(string filePath)
        {
            var tempDataArray = new List<int>();
            using(var reader = new StreamReader(filePath))
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
            foreach(var line in array) {
                Console.WriteLine(line.ToString());
            }
        }
    }
}
