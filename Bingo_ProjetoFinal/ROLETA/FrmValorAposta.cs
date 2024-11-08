using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Bingo_ProjetoFinal
{
    public partial class FrmValorAposta : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        public FrmValorAposta()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            if (rbt1.Checked == true)
            {
                
                if (FrmMain.saldo < 1)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 1;
                    MessageBox.Show("Aposta feita! Atualize a lista de apostas para aplica-la");
                    if (FrmMain.flagGrupal12 == true)
                    {
                        FrmMain.contadorApostaGrupal = 12;
                    }
                    else if (FrmMain.flagGrupal18 == true)
                    {
                        FrmMain.contadorApostaGrupal = 18;
                    }
                    else
                    {
                        FrmMain.contadorApostaIndividual++;
                    }
                    this.Close();
                }
            }
            else if (rbt5.Checked == true)
            {
                if (FrmMain.saldo < 5)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 5;
                    MessageBox.Show("Aposta feita! Atualize a lista de apostas para aplica-la");
                    if (FrmMain.flagGrupal12 == true)
                    {
                        FrmMain.contadorApostaGrupal = 12;
                    }
                    else if (FrmMain.flagGrupal18 == true)
                    {
                        FrmMain.contadorApostaGrupal = 18;
                    }
                    else
                    {
                        FrmMain.contadorApostaIndividual++;
                    }
                    this.Close();
                }
            }
            else if (rbt10.Checked == true)
            {
                if (FrmMain.saldo < 10)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 10;
                    MessageBox.Show("Aposta feita! Atualize a lista de apostas para aplica-la");
                    if (FrmMain.flagGrupal12 == true)
                    {
                        FrmMain.contadorApostaGrupal = 12;
                    }
                    else if (FrmMain.flagGrupal18 == true)
                    {
                        FrmMain.contadorApostaGrupal = 18;
                    }
                    else
                    {
                        FrmMain.contadorApostaIndividual++;
                    }
                    this.Close();
                }
            }
            else if (rbt20.Checked == true)
            {
                if (FrmMain.saldo < 20)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 20;
                    MessageBox.Show("Aposta feita! Atualize a lista de apostas para aplica-la");
                    if (FrmMain.flagGrupal12 == true)
                    {
                        FrmMain.contadorApostaGrupal = 12;
                    }
                    else if (FrmMain.flagGrupal18 == true)
                    {
                        FrmMain.contadorApostaGrupal = 18;
                    }
                    else
                    {
                        FrmMain.contadorApostaIndividual++;
                    }
                    this.Close();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            classeMusica.musicaSair();
            this.Close();
        }
    }
}
