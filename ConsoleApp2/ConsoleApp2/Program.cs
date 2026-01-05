using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxHP = 133;
            int HP = 78;
            int Attack = 88;
            int Defense = 77;
            int SpAtk = 110;
            int SpDef = 76;
            int Speed = 120;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃                     HP:  {HP} / {MaxHP}                        ┃");
            Console.WriteLine($"┃                     Attack:  {Attack}                          ┃");
            Console.WriteLine($"┃                     Defense:  {Defense}                         ┃");
            Console.WriteLine($"┃                     Sp.Atk:  {SpAtk}                         ┃");
            Console.WriteLine($"┃                     Sp.Def:  {SpDef}                          ┃");
            Console.WriteLine($"┃                     Speed:  {Speed}                          ┃");

            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }
    }
}
