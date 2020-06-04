using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Mario :");
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();

            System.Console.WriteLine("\nLuigi :");
            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
        }
    }
}
