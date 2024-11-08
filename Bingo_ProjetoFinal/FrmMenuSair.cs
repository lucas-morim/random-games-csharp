using Bingo_ProjetoFinal.MILIONÁRIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_ProjetoFinal
{
    public partial class FrmMenuSair : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        public FrmMenuSair()
        {
            InitializeComponent();
            if (FrmMain.flagBingo == true)
            {
                btnNovoJogo.Visible = true;
            }
            
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {

                FrmMain.flagBingo = false;
                classeMusica.musicaJogar();
                this.Close();

                FrmQtdJogadores fnj = new FrmQtdJogadores();
                fnj.Show();
            
            
        }

        private void btnOutrosJogos_Click(object sender, EventArgs e)
        {
            FrmMain.flagBingo = false;
            classeMusica.musicaJogar();

            this.Close();
            FrmMenuJogos fm = new FrmMenuJogos();
            fm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            Application.Exit();
        }
    }
}
