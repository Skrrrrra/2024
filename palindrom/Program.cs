using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2024\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2024\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            double a;
            using (var readera = new StreamReader(inputpath))
            {
                a = Convert.ToInt32(readera.ReadLine());  // записываем в переменную
            };
            //запись в строку содержимого 2 строки файла
            string secondLine;
            using (var readersecond = new StreamReader(inputpath))
            {
                readersecond.ReadLine(); //пропуск 1 строки
                secondLine = readersecond.ReadLine();  // записываем в переменную
            }

            //запись из строки в массив строк с разделением
            string[] secondlineforint = secondLine.Split(' ');

            int[] A;
            A = new int[Convert.ToInt32(a)];

            int[] B;
            B = new int[Convert.ToInt32(a)];


            //запись элементов в А
            int count = 0;
            foreach (var s in secondlineforint)
            {
                if (count <= a)
                {
                    A[count] = Convert.ToInt32(s);
                    
                    count++;
                }
            }
            count = 0;
            foreach (var s in secondlineforint)
            {
                if (count <= a)
                {
                    B[count] = Convert.ToInt32(s);

                    count++;
                }
            }

            B.Reverse();


            double middle = a;
            if (a % 2 == 0)
            {
                middle = a / 2;
            }
            else middle = Math.Round(a / 2);
            double end = Convert.ToInt32(a);


            int counter = 0;
            string outputstring = "";
            for (int i = 0; i < middle & end> middle; i++)
            {
                if (A[i] != B[Convert.ToInt32(end-1)])
                {
                    counter++;
                    end--;
                }
            }
            outputstring = outputstring + counter.ToString();

            File.WriteAllText(outputpath, outputstring);

        }
    }
}
