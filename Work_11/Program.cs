using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.   Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать
//с помощью полей вещественного типа. Для решения уравнения предусмотреть метод Root. Создать экземпляр
//разработанной структуры. Осуществить использование экземпляра в программе.
namespace Part_1

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Решение линейного уравнения 0=kX+b \nВведите коэфициент k=");
            double k=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэфициент b=");
            double b = Convert.ToDouble(Console.ReadLine());
            linEq LinEq = new linEq(k, b);
            Console.WriteLine(LinEq.Root());
            Console.ReadKey();
        }
    }
}
