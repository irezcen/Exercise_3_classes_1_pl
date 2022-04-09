using System;

namespace zadanie_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            trójkątprostokątny trojkat1 = new trójkątprostokątny();
            trójkątprostokątny trójkąt2 = new trójkątprostokątny();
            trójkątprostokątny trójkąt3 = new trójkątprostokątny();
            trojkat1.kolor = "czerwony";
            trojkat1.A = 10;
            trojkat1.B = 5;
            trójkąt2.B = 3;
            trójkąt2.A = 7.5;
            trójkąt3.A = 7;
            trójkąt3.B = 12.5;
            trójkąt2.kolor = "maślany";
            Console.WriteLine(trójkąt3.oblicztanges());
            Console.WriteLine(trójkąt2.kolor);
            Console.WriteLine(Math.Round(trojkat1.obwod, 2));
        }
    }
}
