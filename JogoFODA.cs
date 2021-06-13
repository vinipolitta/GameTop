using System;

namespace GameTop
{
     public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;


        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;

        }
        public void IniciarJogo()
        {
            Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorA.Chuta());
            Console.Write(_jogadorA.Passa());

            Console.Write("\n PROXIMO JOGADOR \n\n");   

            Console.Write(_jogadorB.Corre());
            Console.Write(_jogadorB.Chuta());
            Console.Write(_jogadorB.Passa());

        }
     }
}