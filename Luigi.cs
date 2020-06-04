namespace Polimorfismo
{
    public class Luigi : Player
    {
        public override void Pular(){
            //Aprovetimaos as ações da superclasse
            base.Pular();

            //Adicionando novas ações
            System.Console.WriteLine("O Luigi também pode pular 30% mais alto");
        }
    }
}