using System;

namespace Polimorfismo
{
    public class Player
    {
        
        public virtual void Pular(){
            System.Console.WriteLine("O personagem está pulando normlamente");
        }
        public virtual void Correr(){
            System.Console.WriteLine("O personagem está correndo normalmente");
        }
    }
}