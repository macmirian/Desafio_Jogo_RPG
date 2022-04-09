using System;
using src.Entities;

namespace desafio_abstraindo_um_jogo_rpg
{
    class Program
    {
        static void Main(string[] args) 
        {   
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 51, "Ninja");
        
            Console.WriteLine(jennica.Attack());
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(wedge.Attack());

        }
    }
}
