using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_ProjetoFinal
{  
    public partial class FrmMain : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        public static int saldo = 0;
        public static int saldoAdicionado = 0;
        public static int aposta = 0;
        public static int contadorApostaIndividual = 0;
        public static int contadorApostaGrupal = 0;
        public static bool flagGrupal12 = false;
        public static bool flagGrupal18 = false;
        public static bool flagBingo = false;

        public FrmMain()
        {
            InitializeComponent();
            classeMusica.musicaFundoConstante();
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            this.Hide();
            FrmMenuJogos ftj = new FrmMenuJogos();
            ftj.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            Application.Exit();
        }
    }
}
