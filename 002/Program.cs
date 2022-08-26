//адача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения b1, k1, b2, k2 уравнений y = k1*x + b1, y = k2*x + b2");
        double b1 = Convert.ToInt32(Console.ReadLine());
        double k1 = Convert.ToInt32(Console.ReadLine());
        double b2 = Convert.ToInt32(Console.ReadLine());
        double k2 = Convert.ToInt32(Console.ReadLine());
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        if ((k1 == k2) & !(b1 == b2))
        {
            Console.WriteLine("Прямые параллельны");
        }
        if (k1 == k2 & b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        if (!(k1 == k2))
        {
            Console.WriteLine("Точка пересечения двух прямых ");
            Console.WriteLine($"({x}, {y})");
        }
    }
}