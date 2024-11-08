using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Bingo_ProjetoFinal
{
    internal class ClassMusica
    {
        private readonly string pastaOriginal;

        public ClassMusica()
        {
            pastaOriginal = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void PlaySound(string pastaEfetiva)
        {
            string pastaMusica = Path.Combine(pastaOriginal, pastaEfetiva);
            using (SoundPlayer player = new SoundPlayer(pastaMusica))
                {
                    player.Play();
                }
            
        }

        public void musicaJogar()
        {
            PlaySound("Musica\\JOGAR.wav");
        }

        public void musicaSair()
        {
            PlaySound("Musica\\SAIR.wav");
        }

        public void musicaFundoConstante()
        {
            PlaySound("Musica\\INICIO.wav");
        }

        public void musicaNovoNum()
        {
            PlaySound("Musica\\NOVO_NUMERO.wav");
        }

        public void musicaTeclado()
        {
            PlaySound("Musica\\TECLADO.wav");
        }
        public void musicaLinha()
        {
            PlaySound("Musica\\Linha.wav");
        }
        public void musicaBingo()
        {
            PlaySound("Musica\\Bingo.wav");
        }

        public void musicaIntro()
        {
            PlaySound("Musica\\INTRO.wav");
        }

        public void musicaAcertou()
        {
            PlaySound("Musica\\ACERTOU.wav");
        }

        public void musicaResponder()
        {
            PlaySound("Musica\\RESPONDER.wav");
        }

        public void musicaErrou()
        {
            PlaySound("Musica\\ERROU.wav");
        }

        public void musicaGanhou()
        {
            PlaySound("Musica\\VITORIA.wav");
        }

        public void musicaMoney()
        {
            PlaySound("Musica\\MONEY.wav");
        }

        public void musicaErrado()
        {
            PlaySound("Musica\\ERRADO.wav");
        }

        public void musicaCerto()
        {
            PlaySound("Musica\\CERTO.wav");
        }
    }
}
