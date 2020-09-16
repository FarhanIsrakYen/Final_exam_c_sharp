using System;
using System.IO;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("C:\\Users\\Yen\\Desktop\\Exam.txt"))
            {
                Console.WriteLine("Please write something in the file");
                string something = Console.ReadLine();
                File.WriteAllText("C:\\Users\\Yen\\Desktop\\Exam.txt", something);
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
            if (File.Exists("C:\\Users\\Yen\\Desktop\\Exam.txt"))
            {
                var data = File.ReadAllText("C:\\Users\\Yen\\Desktop\\Exam.txt");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
        }
    }
}
