using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop12
{

    delegate double MathOperation(double x, double y);

    class Program
    {
        static double Add(double x, double y) => x + y;
        static double Subtract(double x, double y) => x - y;
        static double Multiply(double x, double y) => x * y;
        static double Divide(double x, double y) => y != 0 ? x / y : double.NaN;

        static double PerformOperation(double x, double y, MathOperation operation)
        {
            return operation(x, y);
        }

        static void Main()
        {
            MathOperation addDelegate = Add;
            MathOperation subtractDelegate = Subtract;
            MathOperation multiplyDelegate = Multiply;
            MathOperation divideDelegate = Divide;

            double resultAdd = PerformOperation(5, 3, addDelegate);
            Console.WriteLine($"Результат сложения: {resultAdd}");

            double resultSubtract = PerformOperation(5, 3, subtractDelegate);
            Console.WriteLine($"Результат вычитания: {resultSubtract}");

            double resultMultiply = PerformOperation(5, 3, multiplyDelegate);
            Console.WriteLine($"Результат умножения: {resultMultiply}");

            double resultDivide = PerformOperation(5, 3, divideDelegate);
            Console.WriteLine($"Результат деления: {resultDivide}");

            MathOperation powerDelegate = delegate (double x, double y)
            {
                return Math.Pow(x, y);
            };
            double resultPower = PerformOperation(2, 3, powerDelegate);
            Console.WriteLine($"Результат возведения в степень: {resultPower}");

            MathOperation sqrtDelegate = (x, y) => Math.Pow(x, 1 / y);
            double resultSqrt = PerformOperation(9, 2, sqrtDelegate);
            Console.WriteLine($"Результат извлечения корня: {resultSqrt}");

            MathOperation chainDelegate = addDelegate + multiplyDelegate + sqrtDelegate;
            double resultChain = chainDelegate(2, 3);
            Console.WriteLine($"Результат цепочки делегатов: {resultChain}");

            Console.ReadKey();
        }
    }

}
