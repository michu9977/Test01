using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("podaj wzrost i mase");
            double masa = double.Parse(Console.ReadLine());

            double wzrost = double.Parse(Console.ReadLine());

            Double bmi = wzrost/(masa * masa);
            Console.WriteLine(bmi);


            pracownik pracowniczek = new pracownik();
            
            Console.ReadKey();
    }
    }
    public class pracownik
    {
        public char imie;
        public char nazwisko;
        public double pensja;
        void RoczneZarobki(int pensja)
        {
            Console.WriteLine("Roczna pensja pracownika wynosi" + (pensja * 12));
        }
    }
    
   
}
