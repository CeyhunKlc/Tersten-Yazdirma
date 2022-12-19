using System;

namespace metniterscevirenuygulama
{ 
    class program
    { 
        static void Main(string[] args)
        { 
            string Metin;
            Console.WriteLine("Lütfen Metin Giriniz:");
            Metin = Console.ReadLine();
            for (int i = 0; i < Metin.Length ; i++)
            {
                Console.Write(Metin[Metin.Length - i - 1]);
            }
            Console.WriteLine();
        }
    }
}