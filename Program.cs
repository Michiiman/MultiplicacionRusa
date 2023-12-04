using System.Data;
using System;
using System.Threading.Tasks;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese multiplicador: ");
        int m1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese multiplicando: ");
        int m2 = int.Parse(Console.ReadLine());
        Console.WriteLine(multiplicacion(m1, m2));
    }

    static int multiplicacion(int m1, int m2)
    {
        int sum = 0;

        while (m1 != 1)
        {
            if ((m1 % 2) > 0)
            {
                sum += m2;
            }
            m1 = m1 / 2;
            m2 = m2 * 2;

        }
        sum = sum + m2;
        return sum;
    }
}
