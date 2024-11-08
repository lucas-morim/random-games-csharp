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
    public partial class FrmRoleta : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        
        Random rnd = new Random();
        int apostaNovo = 0;
        int apostaTotal = 0;
        int[] numApostados = new int[20];
        string tipoAposta;

        public FrmRoleta(int s, int a)
        {
            InitializeComponent();
            lblSaldo.Text = (FrmMain.saldo.ToString()+ "€");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
            FrmMenuSair opc = new FrmMenuSair();
            opc.Show();
        }

        private void btnGirarRoleta_Click(object sender, EventArgs e)
        {
            int rndNumb;
            int multiplicador = 0;
            FrmMain.flagGrupal12 = false;
            FrmMain.flagGrupal18 = false;
            
            classeMusica.musicaNovoNum();
            lboxNumeros.Items.Clear();
            desbloquearBotoes();

            if (FrmMain.aposta != 0)
            {
                lboxApostas.Items.Add("--------------------------------");
            }

            rndNumb = rnd.Next(0,37);
            lboxNumeros.Items.Add(rndNumb);

            if (FrmMain.contadorApostaIndividual == 1)
            {
                multiplicador = 35;
            }
            else if (FrmMain.contadorApostaIndividual == 2)
            {
                multiplicador = 17;
            }
            else if (FrmMain.contadorApostaIndividual == 3)
            {
                multiplicador = 11;
            }
            else if (FrmMain.contadorApostaIndividual == 4)
            {
                multiplicador = 8;
            }
            else if (FrmMain.contadorApostaIndividual == 5)
            {
                multiplicador = 6;
            }
            else if (FrmMain.contadorApostaIndividual == 6)
            {
                multiplicador = 5;
            }
            else if (FrmMain.contadorApostaGrupal == 12)
            {
                multiplicador = 3;
            }
            else if (FrmMain.contadorApostaGrupal == 18)
            {
                multiplicador = 2;
            }

            for (int i = 0; i < 20; i++)
            {
                if (rndNumb == numApostados[i])
                {
                    FrmMain.saldo += apostaTotal * multiplicador;
                    lblSaldo.Text = FrmMain.saldo.ToString() + "€";
                }
            }
            FrmMain.aposta = 0;
            FrmMain.contadorApostaIndividual = 0;
            FrmMain.contadorApostaGrupal = 0;
            apostaTotal = 0;
            for (int i = 0; i < 20; i++)
            {
                numApostados[i] = -1;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboxApostas.Items.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            numApostados[FrmMain.contadorApostaIndividual] = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            numApostados[FrmMain.contadorApostaIndividual] = 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 9;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 10;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 11;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 12;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 13;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 14;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 15;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 16;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            numApostados[FrmMain.contadorApostaIndividual] = 17;

            
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 18;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 19;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 20;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 21;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 22;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 23;
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 24;
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 25;
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 26;
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 27;
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 28;
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 29;
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 30;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 31;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 32;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 33;
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;
            
            numApostados[FrmMain.contadorApostaIndividual] = 34;
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;

            numApostados[FrmMain.contadorApostaIndividual] = 35;
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            fva.ShowDialog();
            verificarApostaIndividuais();
            btnAtualizarAposta.Enabled = true;

            numApostados[FrmMain.contadorApostaIndividual] = 36;
        }

        private void btnLinha1_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal12 = true;
            fva.ShowDialog();
            verificarApostaGrupais();
            
            btnAtualizarAposta.Enabled = true;

            for(int i = 0; i < 13; i++)
            {
                numApostados[i] = 3+(i*3);
            }
            tipoAposta = "Linha1";
        }

        private void btnLinha2_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal12 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 13; i++)
            {
                numApostados[i] = 2 + (i * 3);
            }
            tipoAposta = "Linha2";
        }

        private void btnLinha3_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal12 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 13; i++)
            {
                numApostados[i] = 1 + (i * 3);
            }
            tipoAposta = "Linha3";
        }

        private void btn1Duzia_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal12 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 12; i++)
            {
                numApostados[i] = 1 + i;
            }
            tipoAposta = "1a Duzia";
        }

        private void btn2Duzia_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal12 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 12; i++)
            {
                numApostados[i] = 13 + i;
            }
            tipoAposta = "2a Duzia";
        }

        private void btn3Duzia_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal12 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 12; i++)
            {
                numApostados[i] = 25 + i;
            }
            tipoAposta = "3a Duzia";
        }

        private void btn1A18_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal18 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 19; i++)
            {
                numApostados[i] = 1 + i;
            }
            tipoAposta = "1 a 18";
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal18 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 19; i++)
            {
                numApostados[i] = 2 + (i*2);
            }
            tipoAposta = "Par";
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal18 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            numApostados[0] = 1;
            numApostados[1] = 3;
            numApostados[2] = 5;
            numApostados[3] = 7;
            numApostados[4] = 9;
            numApostados[5] = 12;
            numApostados[6] = 14;
            numApostados[7] = 16;
            numApostados[8] = 18;
            numApostados[9] = 19;
            numApostados[10] = 21;
            numApostados[11] = 23;
            numApostados[12] = 25;
            numApostados[13] = 27;
            numApostados[14] = 30;
            numApostados[15] = 32;
            numApostados[16] = 34;
            numApostados[17] = 36;

            tipoAposta = "Vermelho";
        }

        private void btnPreto_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal18 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            numApostados[0] = 2;
            numApostados[1] = 4;
            numApostados[2] = 6;
            numApostados[3] = 8;
            numApostados[4] = 10;
            numApostados[5] = 11;
            numApostados[6] = 13;
            numApostados[7] = 15;
            numApostados[8] = 17;
            numApostados[9] = 20;
            numApostados[10] = 22;
            numApostados[11] = 24;
            numApostados[12] = 26;
            numApostados[13] = 28;
            numApostados[14] = 29;
            numApostados[15] = 31;
            numApostados[16] = 33;
            numApostados[17] = 35;

            tipoAposta = "Preto";
        }

        private void btnImpar_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal18 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 19; i++)
            {
                numApostados[i] = 1 + (i * 2);
            }

            tipoAposta = "Impar";
        }

        private void btn19A36_Click(object sender, EventArgs e)
        {
            FrmValorAposta fva = new FrmValorAposta();
            FrmMain.flagGrupal18 = true;
            fva.ShowDialog();
            verificarApostaGrupais();

            btnAtualizarAposta.Enabled = true;

            for (int i = 0; i < 19; i++)
            {
                numApostados[i] = 19 + i;
            }
            tipoAposta = "19 a 36";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Visible = false;
            btnAtualizarSaldo.Visible = true;
            FrmSaldo fs = new FrmSaldo();
            fs.ShowDialog();
        }

        private void btnAtualizarSaldo_Click(object sender, EventArgs e)
        {
            btnAtualizarSaldo.Visible = false;
            FrmMain.saldo += FrmMain.saldoAdicionado;
            lblSaldo.Text = (FrmMain.saldo.ToString()+ "€");
            btnAdicionar.Visible = true;
            FrmMain.saldoAdicionado = 0;
        }

        private void btnAtualizarAposta_Click(object sender, EventArgs e)
        {
            if (FrmMain.contadorApostaIndividual > 0)
            {
                lboxApostas.Items.Add("Num: " + numApostados[FrmMain.contadorApostaIndividual].ToString() + " | Val: " + FrmMain.aposta.ToString() + "€");
            }
            else 
            {
                lboxApostas.Items.Add(tipoAposta + " | Val: " + FrmMain.aposta.ToString() + "€");
            }
            
            apostaNovo = FrmMain.aposta;
            FrmMain.saldo -= apostaNovo;
            apostaTotal += FrmMain.aposta;
            lblSaldo.Text = (FrmMain.saldo.ToString()+ "€");
            btnAtualizarAposta.Enabled = false; 
            apostaNovo = 0;
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            btnAdicionar.Visible = false;
            btnAtualizarSaldo.Visible = true;
            FrmSacarDinheiro fsa = new FrmSacarDinheiro();
            fsa.ShowDialog();
        }

        private void verificarApostaIndividuais()
        {  
            if (FrmMain.contadorApostaIndividual == 1)
            {
                btnLinha1.Enabled = false;
                btnLinha2.Enabled = false;
                btnLinha3.Enabled = false;
                btn1Duzia.Enabled = false;
                btn2Duzia.Enabled = false;
                btn3Duzia.Enabled = false;
                btn1A18.Enabled = false;
                btn19A36.Enabled = false;
                btnPar.Enabled = false;
                btnImpar.Enabled = false;
                btnVermelho.Enabled = false;
                btnPreto.Enabled = false;
            }
            else if (FrmMain.contadorApostaIndividual == 6)
            {
                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
                btn18.Enabled = false;
                btn19.Enabled = false;
                btn20.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
                btn23.Enabled = false;
                btn24.Enabled = false;
                btn25.Enabled = false;
                btn26.Enabled = false;
                btn27.Enabled = false;
                btn28.Enabled = false;
                btn29.Enabled = false;
                btn30.Enabled = false;
                btn31.Enabled = false;
                btn32.Enabled = false;
                btn33.Enabled = false;
                btn34.Enabled = false;
                btn35.Enabled = false;
                btn36.Enabled = false;
                MessageBox.Show("Quantidade de apostas indiviuais máxima atingida!");
            }
        }

        private void verificarApostaGrupais()
        {
            if (FrmMain.contadorApostaGrupal == 6 || FrmMain.contadorApostaGrupal == 12 || FrmMain.contadorApostaGrupal == 18)
            {
                btnLinha1.Enabled = false;
                btnLinha2.Enabled = false;
                btnLinha3.Enabled = false;
                btn1Duzia.Enabled = false;
                btn2Duzia.Enabled = false;
                btn3Duzia.Enabled = false;
                btn1A18.Enabled = false;
                btn19A36.Enabled = false;
                btnPar.Enabled = false;
                btnImpar.Enabled = false;
                btnVermelho.Enabled = false;
                btnPreto.Enabled = false;
                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
                btn18.Enabled = false;
                btn19.Enabled = false;
                btn20.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
                btn23.Enabled = false;
                btn24.Enabled = false;
                btn25.Enabled = false;
                btn26.Enabled = false;
                btn27.Enabled = false;
                btn28.Enabled = false;
                btn29.Enabled = false;
                btn30.Enabled = false;
                btn31.Enabled = false;
                btn32.Enabled = false;
                btn33.Enabled = false;
                btn34.Enabled = false;
                btn35.Enabled = false;
                btn36.Enabled = false;
                MessageBox.Show("Quantidade de apostas grupais máxima atingida!");
            }
        }

        private void desbloquearBotoes()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btn16.Enabled = true;
            btn17.Enabled = true;
            btn18.Enabled = true;
            btn19.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn24.Enabled = true;
            btn25.Enabled = true;
            btn26.Enabled = true;
            btn27.Enabled = true;
            btn28.Enabled = true;
            btn29.Enabled = true;
            btn30.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
            btn34.Enabled = true;
            btn35.Enabled = true;
            btn36.Enabled = true;
            btnLinha1.Enabled = true;
            btnLinha2.Enabled = true;
            btnLinha3.Enabled = true;
            btn1Duzia.Enabled = true;
            btn2Duzia.Enabled = true;
            btn3Duzia.Enabled = true;
            btn1A18.Enabled = true;
            btn19A36.Enabled = true;
            btnPar.Enabled = true;
            btnImpar.Enabled = true;
            btnVermelho.Enabled = true;
            btnPreto.Enabled = true;
        }
    }
}
