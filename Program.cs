using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new JogoFODA(new Jogador("Ronaldo"));
           jogo.IniciarJogo();
        }
    }

    public class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        //chuta
        public void Chuta()
        {
            Console.Write($"{_Nome} esta Chutaando");
        }
        //corre
        public void Corre()
        {
            Console.Write($"{_Nome} esta Correndo");
        }
        //passe
        public void Passe()
        {
            Console.Write($"{_Nome} esta Passando");
        }
    }
}
