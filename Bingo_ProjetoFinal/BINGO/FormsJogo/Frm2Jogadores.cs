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
    public partial class Frm2Jogadores : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        Random rnd = new Random();
        int[,] mat = new int[5, 5];
        int[,] mat2 = new int[5, 5];
        int contador = 0;
        int contador2 = 0;
        int contagem = 0;
        int contagemMeio = 0;
        int contagem2 = 0;
        int contagemMeio2 = 0;
        int[] alturas = new int[25];
        int[] alturas2 = new int[25];
        string y = null;
        string nomeJogador1 = null;
        string nomeJogador2 = null;
        bool[] numerosGerados = new bool[76];
        bool flagGanhou = false;
        bool flagLinha = false;

        public Frm2Jogadores(string nome1, string nome2)
        {
            InitializeComponent();
            nomeJogador1 = nome1;
            nomeJogador2 = nome2;
            gbxCartela1.Text = "Cartela de " + nome1;
            gbxCartela2.Text = "Cartela de " + nome2;

            Button[,] botoes = {
            {btn_1_Cart_1, btn_6_Cart_1, btn_11_Cart_1, btn_16_Cart_1, btn_21_Cart_1},
            {btn_2_Cart_1, btn_7_Cart_1, btn_12_Cart_1, btn_17_Cart_1, btn_22_Cart_1},
            {btn_3_Cart_1, btn_8_Cart_1, null,          btn_18_Cart_1, btn_23_Cart_1},
            {btn_4_Cart_1, btn_9_Cart_1, btn_14_Cart_1, btn_19_Cart_1, btn_24_Cart_1},
            {btn_5_Cart_1, btn_10_Cart_1,btn_15_Cart_1, btn_20_Cart_1, btn_25_Cart_1}};

            Button[,] botoes2 = {
            {btn_1_Cart_2, btn_6_Cart_2, btn_11_Cart_2, btn_16_Cart_2, btn_21_Cart_2},
            {btn_2_Cart_2, btn_7_Cart_2, btn_12_Cart_2, btn_17_Cart_2, btn_22_Cart_2},
            {btn_3_Cart_2, btn_8_Cart_2, null,          btn_18_Cart_2, btn_23_Cart_2},
            {btn_4_Cart_2, btn_9_Cart_2, btn_14_Cart_2, btn_19_Cart_2, btn_24_Cart_2},
            {btn_5_Cart_2, btn_10_Cart_2,btn_15_Cart_2, btn_20_Cart_2, btn_25_Cart_2}};

            criarCartelas(botoes, mat);
            criarCartelas(botoes2, mat2);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmMain.flagBingo = true;
            classeMusica.musicaSair();
            this.Close();
            FrmMenuSair opc = new FrmMenuSair();
            opc.Show();
        }

        private void btnNovoNumero_Click(object sender, EventArgs e)
        {
            int rndNumb;

            classeMusica.musicaNovoNum();
            lboxNumeros.Items.Clear();

            do
            {
                rndNumb = rnd.Next(1, 76);
            } while (numerosGerados[rndNumb]);


            numerosGerados[rndNumb] = true;
            lboxNumeros.Items.Add(rndNumb);

            Button btn1 = this.Controls.OfType<GroupBox>().FirstOrDefault(gb => gb.Name.Contains("gbxCartela1"))
            .Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == rndNumb.ToString());

            if (btn1 != null)
            {
                contador++;
                btn1.BackColor = Color.LightCoral;
                verificarCartelas(btn1, alturas, contador, contagem, contagemMeio, nomeJogador1);
            }

            Button btn2 = this.Controls.OfType<GroupBox>().FirstOrDefault(gb => gb.Name.Contains("gbxCartela2"))
            .Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == rndNumb.ToString());

            if (btn2 != null)
            {
                contador2++;
                btn2.BackColor = Color.DarkCyan;
                verificarCartelas(btn2, alturas2, contador2, contagem2, contagemMeio2, nomeJogador2);
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();

            FrmAjudaBingo aj = new FrmAjudaBingo();
            aj.ShowDialog();
        }

        private void criarCartelas(Button[,] botoes, int[,] mat)
        {
            int[] ranges = {1, 16, 31, 46, 61};

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int rndNum;
                    bool unico;
                    do
                    {
                        rndNum = rnd.Next(ranges[i], ranges[i] + 15);
                        unico = true;
                        for (int k = 0; k < j; k++)
                        {
                            if (mat[i, k] == rndNum)
                            {
                                unico = false;
                                break;
                            }
                        }
                    } while (!unico);
                    mat[i, j] = rndNum;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (botoes[i, j] != null)
                    {
                        botoes[i, j].Text = mat[i, j].ToString();
                    }
                }
            }
        }

        private void verificarCartelas(Button btn, int[] alturas, int contador, int contagem, int contagemMeio, string nomeJogador)
        {
            string textoBotao = null;
            string[] palavras = new string[3];

            textoBotao = btn.Location.ToString();
            palavras = textoBotao.Split('=');
            y = palavras[2];
            string numero = y.Substring(0, y.IndexOf("}"));
            alturas[contador] = int.Parse(numero);
            if (alturas[contador] != 134)
            {
                contagem = alturas.Count(c => c == int.Parse(numero));
            }
            else
            {
                contagemMeio = alturas.Count(c => c == int.Parse(numero));
            }

            if ((contagem == 5 || contagemMeio == 4) && flagLinha == false)
            {
                classeMusica.musicaLinha();
                MessageBox.Show("Linha feita pelo(a) " + nomeJogador);
                flagLinha = true;
            }

            if (contador == 24 && flagGanhou == false)
            {
                classeMusica.musicaBingo();
                btnNovoNumero.Enabled = false;
                MessageBox.Show("O(A) " + nomeJogador + " fez BINGO e ganhou!!!");
                flagGanhou = true;
            }
        }
    }
}
