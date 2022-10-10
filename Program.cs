using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_stack_ornek
{
    internal class Program
    {
        private static int stack;

        static void Main(string[] args)
        {

            // Push(T) Yığının başına öğe ekler.
            // Peek()  Yığının başındaki öğeyi getirir.
            // Pop()   Yığının başındaki öğeyi alıp çıkarır.
            // Contains(T) Öğenin yığın içinde olup olmadığını kontrol eder.
            // Clear() Yığındaki tüm öğeleri siler.

            Stack<int> tabak = new Stack<int>();   

            tabak.Push(0);
            tabak.Push(1);  
            tabak.Push(2);
            tabak.Push(3);
            tabak.Push(4);
            tabak.Push(5);

            foreach (int i in tabak)
            {
                Console.WriteLine(i); // 5,4,3,2,1,0
            }

            Console.WriteLine(tabak.Count);// tabağınn eleman sayisi
            Console.WriteLine();
             

            while(tabak.Count > 0)
            {

                Console.WriteLine("tabaktaki eleman sayisi = {0}", tabak.Count);

                Console.WriteLine(tabak.Pop());


            }

            Console.WriteLine("-------------------");

            ///////// peek
            

            Stack<string> uzayli = new Stack<string>();

            uzayli.Push("u");
            uzayli.Push("z");
            uzayli.Push("a");
            uzayli.Push("y");

            Console.WriteLine("eleman sayisi = {0}",uzayli.Count);

            if(uzayli.Count > 0)
            {
                Console.WriteLine(uzayli.Peek()); // y harfi
            }

            Console.WriteLine("eleman sayisi degismedi = {0}", uzayli.Count);

            Console.WriteLine("-------------------");

            ///////// contains
            

            Stack<int> sayilar = new Stack<int>();

            sayilar.Push(3);
            sayilar.Push(6);
            sayilar.Push(9);
            sayilar.Push(369);

            bool arama1 = sayilar.Contains(9); // true 
            bool arama2 = sayilar.Contains(25); // false

            Console.WriteLine(arama1);
            Console.WriteLine(arama2);




            Console.ReadKey();
        }
    }
}
