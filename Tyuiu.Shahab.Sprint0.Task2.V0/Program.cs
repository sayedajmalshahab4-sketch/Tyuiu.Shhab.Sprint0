using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.Shahab.Sprint0.Task2.V0.Lib;

namespace Tyuiu.Shahab.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метода GetMessage
            //из 6nonnoTeKn Tyuiu.SpirinIS.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Shhab"));
            Console.ReadKey();
        }
    }
}
