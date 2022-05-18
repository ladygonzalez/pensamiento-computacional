using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int cal1, cal2, cal3, cal4;
            double pro1, pro2, pro3, pro4;
            double promFinal;
            Console.WriteLine("ingrese la calificacion 1: ");
            cal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la calificacion 2: ");
            cal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la calificacion 3: ");
            cal3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la calificacion 4: ");
            cal4 = int.Parse(Console.ReadLine());
            pro1 = (cal1 * 30) / 100;
            pro2 = (cal2 * 20) / 100;
            pro3 = (cal3 * 10) / 100;
            pro4 = (cal4 * 40) / 100;
            promFinal = pro1 + pro2 + pro3 + pro4;
            Console.WriteLine("El promedio final es: {0}", promFinal);
            Console.ReadLine();
            



            
        }
    }
}
