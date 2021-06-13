using System;

namespace GameTop
{
     public class JogoFODA
    {
        private readonly Jogador _jogador;

        public JogoFODA(Jogador nome)
        {
            _jogador = nome;
        }
        public void IniciarJogo()
        {
            _jogador.Corre();
            _jogador.Chuta();
            _jogador.Passe();

        }
     }
}