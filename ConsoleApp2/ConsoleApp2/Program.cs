using System;



namespace ConsoleApp2
{
    class Program
    {
        public enum Delta
        {
            UJEMNA ,ZERO ,DODATNIA
        }
        static void Main(string[] args)
        {

            int a = 0, b = 0, c = 0, delta = 0, operacja = 0;
            double x1=0,x2=0;
            Console.WriteLine("Podaj A \n");
            a = System.Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Podaj B \n",b);
            b = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj C \n",c);
            c = System.Int32.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Nie moze wystepowac 0 \n");
            } 
            else
            {
                delta = (b * b) - (4 * a * c);
                Console.WriteLine("Wprowadzono A: " + a + " B: " + b + " C: " + c + " ");
                Console.Write("Delta Wynosi : " + delta + " \n");
            }
            if (delta > 0)
                operacja = 2;
            else
                if (delta == 0)
                operacja = 1;
            else
                operacja = 0;

            switch (operacja)
            {
                case (int) Delta.UJEMNA:
                    Console.WriteLine("Brak Miejsc zerowych");
                    break;

                case (int) Delta.ZERO:
                    x1 = (-b / (2 * a));
                    Console.WriteLine("x1 = " + x1 + " \n");
                    break;

                case (int) Delta.DODATNIA:
                    x1 = (-b - (Math.Sqrt(delta))) / (2 * a);
                    x2 = (-b + (Math.Sqrt(delta))) / (2 * a);

                    Console.WriteLine("x1 = " + x1 + " x2= " + x2 + " \n");
                    break;
            }

        }
    }
}
