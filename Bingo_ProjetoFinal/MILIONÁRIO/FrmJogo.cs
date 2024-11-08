using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_ProjetoFinal.MILIONÁRIO
{
    public partial class FrmJogo : Form
    {
        
        private Timer timer;
        FrmMilionario m = new FrmMilionario();
        int rndNumb;
        int cont = 0;
        private bool[] perguntasgeradas = new bool[122];
        Random rnd = new Random();
        ClassMusica classeMusica = new ClassMusica();
        
        public FrmJogo()
        {
            
            InitializeComponent();
            perguntasGeradas();
            classeMusica.musicaJogar();
            classeMusica.musicaResponder(); 
            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += new EventHandler(tempo);
            timer.Start();
            lblSaldo.Text = (FrmMain.aposta + "€");
            lblSaldo.BackColor = Color.Green;
            lblSaldo2.Text = (FrmMain.aposta + "€");
            if (FrmMain.aposta >= 1)
            {
                lblSaldo2.BackColor = Color.Green;
            }
            else
            {
                lblSaldo2.BackColor = Color.Red;
            }

            btnContinuar.Visible = false;
            btnDesistir.Visible = false;
            btnSair.Visible = false;
            lblPerdeu.Visible = false;
            lblSaldo2.Visible = false;
            btnVitoria.Visible = false;
        }
        public void perguntasGeradas()
        {
            if (cont == 2)
            {
                classeMusica.musicaMoney();
                FrmMain.aposta = (FrmMain.aposta * 2);
                lblSaldo.Text = (FrmMain.aposta + "€");
                lblSaldo2.Text = (FrmMain.aposta + "€");
                timer.Stop();
                lblPergunta.Visible = false;
                btnOpcao1.Visible = false;
                btnOpcao2.Visible = false;
                btnOpcao3.Visible = false;
                btnOpcao4.Visible = false;
                lblSaldo.Visible=false;
                lblPergunta2.Visible = true;
                btnContinuar.Visible = true;
                btnDesistir.Visible = true;
                btnSair.Visible = false;
                btnVitoria.Visible = false;
                lblSaldo2.Visible = true;
            }
            else if (cont == 3)
            {
                classeMusica.musicaMoney();
                FrmMain.aposta = (FrmMain.aposta * 4);
                lblSaldo.Text = (FrmMain.aposta + "€");
                lblSaldo2.Text = (FrmMain.aposta + "€");
                timer.Stop();
                lblPergunta.Visible = false;
                btnOpcao1.Visible = false;
                btnOpcao2.Visible = false;
                btnOpcao3.Visible = false;
                btnOpcao4.Visible = false;
                lblSaldo.Visible = false;
                lblPergunta2.Visible = true;
                btnContinuar.Visible = true;
                btnDesistir.Visible = true;
                btnSair.Visible = false;
                btnVitoria.Visible = false;
                lblSaldo2.Visible = true;

            }
            else if (cont == 4)
            {
                classeMusica.musicaGanhou();
                FrmMain.aposta = (FrmMain.aposta * 6);
                lblSaldo.Text = (FrmMain.aposta + "€");
                lblSaldo2.Text = (FrmMain.aposta + "€");
                timer.Stop();
                lblPergunta.Visible = false;
                btnOpcao1.Visible = false;
                btnOpcao2.Visible = false;
                btnOpcao3.Visible = false;
                btnOpcao4.Visible = false;
                lblSaldo.Visible = false;
                lblPergunta2.Visible = false;
                btnContinuar.Visible = false;
                btnDesistir.Visible = false;
                btnSair.Visible = false;
                lblSaldo2.Visible = true;
                btnVitoria.Visible = true;
                lblGanhou.Visible = true;

            }
            do
            {
                rndNumb = rnd.Next(1, 123);
            }
            while (perguntasgeradas[rndNumb - 1]);
            perguntasgeradas[rndNumb - 1] = true;



            if (rndNumb == 1)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital da França?";
                btnOpcao1.Text = "Madrid";
                btnOpcao2.Text = "Berlim";
                btnOpcao3.Text = "Paris";
                btnOpcao4.Text = "Roma";
            }

            else if (rndNumb == 2)
            {
                cont++;
                lblPergunta.Text = "Qual destes animais é um mamífero?";
                btnOpcao1.Text = "Pinguim";
                btnOpcao2.Text = "Golfinho";
                btnOpcao3.Text = "Tubarão";
                btnOpcao4.Text = "Crocodilo";
            }

            else if (rndNumb == 3)
            {
                cont++;
                lblPergunta.Text = "Qual é o planeta mais próximo do Sol?";
                btnOpcao1.Text = "Mercúrio";
                btnOpcao2.Text = "Júpiter";
                btnOpcao3.Text = "Marte";
                btnOpcao4.Text = "Terra";
            }

            else if (rndNumb == 4)
            {
                cont++;
                lblPergunta.Text = "Em que país se encontra a Torre Eiffel?";
                btnOpcao1.Text = "Alemanha";
                btnOpcao2.Text = "Espanha";
                btnOpcao3.Text = "França";
                btnOpcao4.Text = "Itália";
            }

            else if (rndNumb == 5)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior oceano do mundo?";
                btnOpcao1.Text = "Oceano Atlântico";
                btnOpcao2.Text = "Oceano Índico";
                btnOpcao3.Text = "Oceano Ártico";
                btnOpcao4.Text = "Oceano Pacífico";
            }

            else if (rndNumb == 6)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu Dom Quixote?";
                btnOpcao1.Text = "William Shakespeare";
                btnOpcao2.Text = "Miguel de Cervantes";
                btnOpcao3.Text = "Gabriel García Márquez";
                btnOpcao4.Text = "Fernando Pessoa";
            }

            else if (rndNumb == 7)
            {
                cont++;
                lblPergunta.Text = "Quem foi o primeiro presidente dos Estados Unidos?";
                btnOpcao1.Text = "George Washington";
                btnOpcao2.Text = " Abraham Lincoln";
                btnOpcao3.Text = "John Adams";
                btnOpcao4.Text = "Thomas Jefferson";
            }

            else if (rndNumb == 8)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior deserto do mundo?";
                btnOpcao1.Text = "Deserto do Saara";
                btnOpcao2.Text = "Deserto da Antártida";
                btnOpcao3.Text = "Deserto de Kalahari";
                btnOpcao4.Text = "Deserto de Gobi";
            }

            else if (rndNumb == 9)
            {
                cont++;
                lblPergunta.Text = "Quem pintou a Mona Lisa?";
                btnOpcao1.Text = "Pablo Picasso";
                btnOpcao2.Text = "Vincent van Gogh";
                btnOpcao3.Text = "Leonardo da Vinci";
                btnOpcao4.Text = "Michelangelo";
            }

            else if (rndNumb == 10)
            {
                cont++;
                lblPergunta.Text = "Qual é a moeda oficial do Japão?";
                btnOpcao1.Text = "Yen";
                btnOpcao2.Text = "Dólar";
                btnOpcao3.Text = "Won";
                btnOpcao4.Text = "Yuan";
            }

            else if (rndNumb == 11)
            {
                cont++;
                lblPergunta.Text = "Em que ano ocorreu a queda do Muro de Berlim?";
                btnOpcao1.Text = "1985";
                btnOpcao2.Text = "1991";
                btnOpcao3.Text = "1987";
                btnOpcao4.Text = "1989";
            }

            else if (rndNumb == 12)
            {
                cont++;
                lblPergunta.Text = " Qual é o nome do cientista que formulou a teoria da relatividade?";
                btnOpcao1.Text = "Isaac Newton";
                btnOpcao2.Text = "Albert Einstein";
                btnOpcao3.Text = "Galileo Galilei";
                btnOpcao4.Text = "Niels Bohr";
            }

            else if (rndNumb == 13)
            {
                cont++;
                lblPergunta.Text = "Quem foi o primeiro homem a pisar na Lua?";
                btnOpcao1.Text = " Yuri Gagarin";
                btnOpcao2.Text = "Michael Collins";
                btnOpcao3.Text = "Neil Armstrong";
                btnOpcao4.Text = "Buzz Aldrin";
            }

            else if (rndNumb == 14)
            {
                cont++;
                lblPergunta.Text = "Qual é a obra mais famosa de Homero?";
                btnOpcao1.Text = "Ilíada";
                btnOpcao2.Text = "Eneida";
                btnOpcao3.Text = "A Divina Comédia";
                btnOpcao4.Text = "Édipo Rei";
            }

            else if (rndNumb == 15)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior órgão do corpo humano?";
                btnOpcao1.Text = "Coração";
                btnOpcao2.Text = "Pulmão";
                btnOpcao3.Text = "Fígado";
                btnOpcao4.Text = "Pele";
            }

            else if (rndNumb == 16)
            {
                cont++;
                lblPergunta.Text = "Qual é o nome da série de livros escrita por J.K. Rowling?";
                btnOpcao1.Text = "As Crônicas de Nárnia";
                btnOpcao2.Text = "Harry Potter";
                btnOpcao3.Text = "Jogos Vorazes";
                btnOpcao4.Text = "O Senhor dos Anéis";
            }

            else if (rndNumb == 17)
            {
                cont++;
                lblPergunta.Text = "Qual é o nome da galáxia em que vivemos?";
                btnOpcao1.Text = "Sombrero";
                btnOpcao2.Text = "Andrômeda";
                btnOpcao3.Text = "Whirlpool";
                btnOpcao4.Text = "Via Láctea";
            }

            else if (rndNumb == 18)
            {
                cont++;
                lblPergunta.Text = "Qual é o país mais populoso do mundo?";
                btnOpcao1.Text = "Índia";
                btnOpcao2.Text = " Estados Unidos";
                btnOpcao3.Text = "China";
                btnOpcao4.Text = "Indonésia";
            }

            else if (rndNumb == 19)
            {
                cont++;
                lblPergunta.Text = "Qual é a substância mais dura encontrada na natureza?";
                btnOpcao1.Text = "Diamante";
                btnOpcao2.Text = "Platina";
                btnOpcao3.Text = "Ouro";
                btnOpcao4.Text = "Platina";
            }

            else if (rndNumb == 20)
            {
                cont++;
                lblPergunta.Text = "Quem foi a primeira mulher a ganhar um Prêmio Nobel?";
                btnOpcao1.Text = "Ada Lovelace";
                btnOpcao2.Text = "Rosalind Franklin";
                btnOpcao3.Text = "Marie Curie";
                btnOpcao4.Text = "Jane Goodall";
            }

            else if (rndNumb == 21)
            {
                cont++;
                lblPergunta.Text = "Quem pintou o teto da Capela Sistina?";
                btnOpcao1.Text = "Rafael";
                btnOpcao2.Text = "Michelangelo";
                btnOpcao3.Text = "Leonardo da Vinci";
                btnOpcao4.Text = "Donatello";
            }

            else if (rndNumb == 22)
            {
                cont++;
                lblPergunta.Text = "Quem descobriu a penicilina?";
                btnOpcao1.Text = "Louis Pasteur";
                btnOpcao2.Text = "Marie Curie";
                btnOpcao3.Text = "Joseph Lister";
                btnOpcao4.Text = "Alexander Fleming";
            }

            else if (rndNumb == 23)
            {
                cont++;
                lblPergunta.Text = "Qual foi o primeiro país a conceder o direito de voto às mulheres?";
                btnOpcao1.Text = "Estados Unidos";
                btnOpcao2.Text = "Reino Unido";
                btnOpcao3.Text = "Nova Zelândia";
                btnOpcao4.Text = "Canadá";
            }

            else if (rndNumb == 24)
            {
                cont++;
                lblPergunta.Text = "Em que ano foi fundado o Google?";
                btnOpcao1.Text = "1996";
                btnOpcao2.Text = "1998";
                btnOpcao3.Text = "2000";
                btnOpcao4.Text = "2002";
            }

            else if (rndNumb == 25)
            {
                cont++;
                lblPergunta.Text = "Qual foi a primeira obra literária escrita em português?";
                btnOpcao1.Text = "Os Lusíadas";
                btnOpcao2.Text = "Cancioneiro Geral";
                btnOpcao3.Text = "Amadis de Gaula";
                btnOpcao4.Text = "Auto da Barca do Inferno";
            }

            else if (rndNumb == 26)
            {
                cont++;
                lblPergunta.Text = "Quem inventou o telefone?";
                btnOpcao1.Text = "Nikola Tesla";
                btnOpcao2.Text = "Thomas Edison";
                btnOpcao3.Text = "Alexander Graham Bell";
                btnOpcao4.Text = "Guglielmo Marconi";
            }

            else if (rndNumb == 27)
            {
                cont++;
                lblPergunta.Text = "Em que ano começou a Segunda Guerra Mundial?";
                btnOpcao1.Text = "1939";
                btnOpcao2.Text = "1938";
                btnOpcao3.Text = "1937";
                btnOpcao4.Text = "1940";
            }

            else if (rndNumb == 28)
            {
                cont++;
                lblPergunta.Text = "Qual é a montanha mais alta do mundo?";
                btnOpcao1.Text = "K2";
                btnOpcao2.Text = "Everest";
                btnOpcao3.Text = "Kangchenjunga";
                btnOpcao4.Text = "Lhotse";
            }

            else if (rndNumb == 29)
            {
                cont++;
                lblPergunta.Text = "Qual foi a primeira civilização a usar a escrita?";
                btnOpcao1.Text = "Egípcios";
                btnOpcao2.Text = "Chineses";
                btnOpcao3.Text = "Sumérios";
                btnOpcao4.Text = "Fenícios";
            }

            else if (rndNumb == 30)
            {
                cont++;
                lblPergunta.Text = "Qual é o país mais extenso do mundo?";
                btnOpcao1.Text = "Estados Unidos";
                btnOpcao2.Text = "China";
                btnOpcao3.Text = "Canadá";
                btnOpcao4.Text = "Rússia";
            }

            else if (rndNumb == 31)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital da Argentina?";
                btnOpcao1.Text = "Buenos Aires";
                btnOpcao2.Text = "Santiago";
                btnOpcao3.Text = "Lima";
                btnOpcao4.Text = "Montevidéu";
            }

            else if (rndNumb == 32)
            {
                cont++;
                lblPergunta.Text = "Qual é a maior ilha do mundo?";
                btnOpcao1.Text = "Groenlândia";
                btnOpcao2.Text = "Nova Guiné";
                btnOpcao3.Text = "Bornéu";
                btnOpcao4.Text = "Madagascar";
            }

            else if (rndNumb == 33)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior planeta do sistema solar?";
                btnOpcao1.Text = "Terra";
                btnOpcao2.Text = "Marte";
                btnOpcao3.Text = "Júpiter";
                btnOpcao4.Text = "Saturno";
            }

            else if (rndNumb == 34)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'A Odisséia'?";
                btnOpcao1.Text = "Sófocles";
                btnOpcao2.Text = "Homero";
                btnOpcao3.Text = "Virgílio";
                btnOpcao4.Text = "Eurípedes";
            }

            else if (rndNumb == 35)
            {
                cont++;
                lblPergunta.Text = "Qual é o país conhecido como 'terra do sol nascente'?";
                btnOpcao1.Text = "China";
                btnOpcao2.Text = "Coreia do Sul";
                btnOpcao3.Text = "Japão";
                btnOpcao4.Text = "Tailândia";
            }

            else if (rndNumb == 36)
            {
                cont++;
                lblPergunta.Text = "Quem é o fundador da empresa Amazon?";
                btnOpcao1.Text = "Elon Musk";
                btnOpcao2.Text = "Larry Page";
                btnOpcao3.Text = "Mark Zuckerberg";
                btnOpcao4.Text = "Jeff Bezos";

            }

            else if (rndNumb == 37)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior continente do mundo?";
                btnOpcao1.Text = "Ásia";
                btnOpcao2.Text = "América do Norte";
                btnOpcao3.Text = "África";
                btnOpcao4.Text = "Europa";
            }

            else if (rndNumb == 38)
            {
                cont++;
                lblPergunta.Text = "Quem foi o primeiro brasileiro a ganhar o Prêmio Nobel?";
                btnOpcao1.Text = "Jorge Amado";
                btnOpcao2.Text = "Nenhum brasileiro ganhou";
                btnOpcao3.Text = "Carlos Drummond de Andrade";
                btnOpcao4.Text = "Paulo Coelho";
            }

            else if (rndNumb == 39)
            {
                cont++;
                lblPergunta.Text = "Quem foi o primeiro ministro do Reino Unido durante a Segunda Guerra Mundial?";
                btnOpcao1.Text = "Neville Chamberlain";
                btnOpcao2.Text = "Clement Attlee";
                btnOpcao3.Text = "Winston Churchill";
                btnOpcao4.Text = "Stanley Baldwin";
            }

            else if (rndNumb == 40)
            {
                cont++;
                lblPergunta.Text = "Qual é a maior espécie de felino do mundo?";
                btnOpcao1.Text = "Tigre";
                btnOpcao2.Text = "Leopardo";
                btnOpcao3.Text = "Leão";
                btnOpcao4.Text = "Jaguar";
            }

            else if (rndNumb == 41)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior país da África?";
                btnOpcao1.Text = "Nigéria";
                btnOpcao2.Text = "Argélia";
                btnOpcao3.Text = "Egito";
                btnOpcao4.Text = "África do Sul";
            }

            else if (rndNumb == 42)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'O Pequeno Príncipe'?";
                btnOpcao1.Text = "Hans Christian Andersen";
                btnOpcao2.Text = "J.K. Rowling";
                btnOpcao3.Text = "Antoine de Saint-Exupéry";
                btnOpcao4.Text = "Lewis Carroll";
            }

            else if (rndNumb == 43)
            {
                cont++;
                lblPergunta.Text = "Qual é a língua oficial do Egito?";
                btnOpcao1.Text = "Árabe";
                btnOpcao2.Text = "Francês";
                btnOpcao3.Text = "Inglês";
                btnOpcao4.Text = "Espanhol";
            }

            else if (rndNumb == 44)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'Romeu e Julieta'?";
                btnOpcao1.Text = "William Shakespeare";
                btnOpcao2.Text = "Charles Dickens";
                btnOpcao3.Text = "Jane Austen";
                btnOpcao4.Text = "Mark Twain";
            }

            else if (rndNumb == 45)
            {
                cont++;
                lblPergunta.Text = "Quem inventou a lâmpada elétrica?";
                btnOpcao1.Text = "Nikola Tesla";
                btnOpcao2.Text = "Thomas Edison";
                btnOpcao3.Text = "Alexander Graham Bell";
                btnOpcao4.Text = "Guglielmo Marconi";
            }

            else if (rndNumb == 46)
            {
                cont++;
                lblPergunta.Text = "Qual é a cidade mais populosa do Brasil?";
                btnOpcao1.Text = "Rio de Janeiro";
                btnOpcao2.Text = "Salvador";
                btnOpcao3.Text = "Brasília";
                btnOpcao4.Text = "São Paulo";
            }

            else if (rndNumb == 47)
            {
                cont++;
                lblPergunta.Text = "Qual é o símbolo químico do ouro?";
                btnOpcao1.Text = "Au";
                btnOpcao2.Text = "Ag";
                btnOpcao3.Text = "Fe";
                btnOpcao4.Text = "Pb";
            }

            else if (rndNumb == 48)
            {
                cont++;
                lblPergunta.Text = "Quem descobriu a América?";
                btnOpcao1.Text = "Vasco da Gama";
                btnOpcao2.Text = "Fernão de Magalhães";
                btnOpcao3.Text = "Cristóvão Colombo";
                btnOpcao4.Text = "James Cook";
            }

            else if (rndNumb == 49)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital do México?";
                btnOpcao1.Text = "Guadalajara";
                btnOpcao2.Text = "Cidade do México";
                btnOpcao3.Text = "Monterrey";
                btnOpcao4.Text = "Puebla";
            }

            else if (rndNumb == 50)
            {
                cont++;
                lblPergunta.Text = "Qual é a velocidade da luz?";
                btnOpcao1.Text = "150,000 km/s";
                btnOpcao2.Text = "300,000 km/s";
                btnOpcao3.Text = "450,000 km/s";
                btnOpcao4.Text = "600,000 km/s";
            }

            else if (rndNumb == 51)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior animal terrestre?";
                btnOpcao1.Text = "Elefante africano";
                btnOpcao2.Text = "Rinoceronte branco";
                btnOpcao3.Text = "Girafa";
                btnOpcao4.Text = "Hipopótamo";
            }

            else if (rndNumb == 52)
            {
                cont++;
                lblPergunta.Text = "Quem pintou 'A Noite Estrelada'?";
                btnOpcao1.Text = "Claude Monet";
                btnOpcao2.Text = "Salvador Dalí";
                btnOpcao3.Text = "Pablo Picasso";
                btnOpcao4.Text = "Vincent van Gogh";
            }

            else if (rndNumb == 53)
            {
                cont++;
                lblPergunta.Text = "Qual é o nome científico do ser humano?";
                btnOpcao1.Text = "Homo erectus";
                btnOpcao2.Text = "Homo sapiens";
                btnOpcao3.Text = "Homo habilis";
                btnOpcao4.Text = "Homo neanderthalensis";
            }

            else if (rndNumb == 54)
            {
                cont++;
                lblPergunta.Text = "Qual é a moeda oficial da Índia?";
                btnOpcao1.Text = "Rupia indonésia";
                btnOpcao2.Text = "Rupia paquistanesa";
                btnOpcao3.Text = "Rupia indiana";
                btnOpcao4.Text = "Taka";
            }

            else if (rndNumb == 55)
            {
                cont++;
                lblPergunta.Text = "Quem desenvolveu a teoria da evolução das espécies?";
                btnOpcao1.Text = "Gregor Mendel";
                btnOpcao2.Text = "Jean-Baptiste Lamarck";
                btnOpcao3.Text = "Charles Darwin";
                btnOpcao4.Text = "Alfred Russel Wallace";
            }

            else if (rndNumb == 56)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital da Coreia do Sul?";
                btnOpcao1.Text = "Seul";
                btnOpcao2.Text = "Tóquio";
                btnOpcao3.Text = "Pequim";
                btnOpcao4.Text = "Pyongyang";
            }

            else if (rndNumb == 57)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior mamífero marinho?";
                btnOpcao1.Text = "Orca";
                btnOpcao2.Text = "Baleia azul";
                btnOpcao3.Text = "Golfinho";
                btnOpcao4.Text = "Tubarão-baleia";
            }

            else if (rndNumb == 58)
            {
                cont++;
                lblPergunta.Text = "Qual é o país de origem do samba?";
                btnOpcao1.Text = "Argentina";
                btnOpcao2.Text = "México";
                btnOpcao3.Text = "Cuba";
                btnOpcao4.Text = "Brasil";
            }

            else if (rndNumb == 59)
            {
                cont++;
                lblPergunta.Text = "Qual foi o primeiro animal a ser clonado com sucesso?";
                btnOpcao1.Text = "Cavalo";
                btnOpcao2.Text = "Gato";
                btnOpcao3.Text = "Ovelha";
                btnOpcao4.Text = "Cachorro";
            }

            else if (rndNumb == 60)
            {
                cont++;
                lblPergunta.Text = "Qual é o país mais pequeno do mundo?";
                btnOpcao1.Text = "San Marino";
                btnOpcao2.Text = "Mônaco";
                btnOpcao3.Text = "Nauru";
                btnOpcao4.Text = "Vaticano";
            }

            else if (rndNumb == 61)
            {
                cont++;
                lblPergunta.Text = "Qual é a montanha mais alta da África?";
                btnOpcao1.Text = "Monte Kilimanjaro";
                btnOpcao2.Text = "Monte Elbrus";
                btnOpcao3.Text = "Monte Everest";
                btnOpcao4.Text = "Monte McKinley";
            }

            else if (rndNumb == 62)
            {
                cont++;
                lblPergunta.Text = "Quem pintou 'A Última Ceia'?";
                btnOpcao1.Text = "Leonardo da Vinci";
                btnOpcao2.Text = "Vincent van Gogh";
                btnOpcao3.Text = "Pablo Picasso";
                btnOpcao4.Text = "Michelangelo";
            }

            else if (rndNumb == 63)
            {
                cont++;
                lblPergunta.Text = "Qual é o elemento químico mais leve?";
                btnOpcao1.Text = "Lítio";
                btnOpcao2.Text = "Hidrogênio";
                btnOpcao3.Text = "Oxigênio";
                btnOpcao4.Text = "Carbono";
            }

            else if (rndNumb == 64)
            {
                cont++;
                lblPergunta.Text = "Quem é considerado o pai da psicanálise?";
                btnOpcao1.Text = "B.F. Skinner";
                btnOpcao2.Text = "Carl Jung";
                btnOpcao3.Text = "Sigmund Freud";
                btnOpcao4.Text = "Ivan Pavlov";
            }

            else if (rndNumb == 65)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior animal do mundo?";
                btnOpcao1.Text = "Elefante africano";
                btnOpcao2.Text = "Baleia azul";
                btnOpcao3.Text = "Girafa";
                btnOpcao4.Text = "Hipopótamo";
            }

            else if (rndNumb == 66)
            {
                cont++;
                lblPergunta.Text = "Quem pintou 'O Grito'?";
                btnOpcao1.Text = "Pablo Picasso";
                btnOpcao2.Text = "Vincent van Gogh";
                btnOpcao3.Text = "Salvador Dalí";
                btnOpcao4.Text = "Edvard Munch";
            }

            else if (rndNumb == 67)
            {
                cont++;
                lblPergunta.Text = "Qual é a língua oficial da China?";
                btnOpcao1.Text = "Inglês";
                btnOpcao2.Text = "Mandarim";
                btnOpcao3.Text = "Cantonês";
                btnOpcao4.Text = "Hakka";
            }

            else if (rndNumb == 68)
            {
                cont++;
                lblPergunta.Text = "Qual é o rio mais extenso do mundo?";
                btnOpcao1.Text = "Rio Amazonas";
                btnOpcao2.Text = "Rio Nilo";
                btnOpcao3.Text = "Rio Yangtzé";
                btnOpcao4.Text = "Rio Mississipi";
            }

            else if (rndNumb == 69)
            {
                cont++;
                lblPergunta.Text = "Quem foi o inventor do telefone?";
                btnOpcao1.Text = "Thomas Edison";
                btnOpcao2.Text = "Nikola Tesla";
                btnOpcao3.Text = "Alexander Graham Bell";
                btnOpcao4.Text = "Guglielmo Marconi";
            }

            else if (rndNumb == 70)
            {
                cont++;
                lblPergunta.Text = "Quem é conhecido como o 'Pai da Computação'?";
                btnOpcao1.Text = "Bill Gates";
                btnOpcao2.Text = "Alan Turing";
                btnOpcao3.Text = "Steve Jobs";
                btnOpcao4.Text = "Tim Berners-Lee";
            }

            else if (rndNumb == 71)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'Crime e Castigo'?";
                btnOpcao1.Text = "Fyodor Dostoevsky";
                btnOpcao2.Text = "Leo Tolstoy";
                btnOpcao3.Text = "Anton Chekhov";
                btnOpcao4.Text = "Nikolai Gogol";
            }

            else if (rndNumb == 72)
            {
                cont++;
                lblPergunta.Text = "Qual é o país com o maior número de ilhas no mundo?";
                btnOpcao1.Text = "Suécia";
                btnOpcao2.Text = "Canadá";
                btnOpcao3.Text = "Indonésia";
                btnOpcao4.Text = "Filipinas";
            }

            else if (rndNumb == 73)
            {
                cont++;
                lblPergunta.Text = "Qual é o metal mais abundante na crosta terrestre?";
                btnOpcao1.Text = "Ouro";
                btnOpcao2.Text = "Alumínio";
                btnOpcao3.Text = "Prata";
                btnOpcao4.Text = "Ferro";
            }

            else if (rndNumb == 74)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'O Hobbit'?";
                btnOpcao1.Text = "C.S. Lewis";
                btnOpcao2.Text = "George R.R.Martin";
                btnOpcao3.Text = "J.K. Rowling";
                btnOpcao4.Text = "J.R.R. Tolkien";
            }

            else if (rndNumb == 75)
            {
                cont++;
                lblPergunta.Text = "Quem foi o autor de 'A Metamorfose'?";
                btnOpcao1.Text = "Franz Kafka";
                btnOpcao2.Text = "Leo Tolstoy";
                btnOpcao3.Text = "Fyodor Dostoevsky";
                btnOpcao4.Text = "Anton Chekhov";
            }

            else if (rndNumb == 76)
            {
                cont++;
                lblPergunta.Text = "Qual é o metal mais caro do mundo?";
                btnOpcao1.Text = "Platina";
                btnOpcao2.Text = "Ouro";
                btnOpcao3.Text = "Ródio";
                btnOpcao4.Text = "Paládio";
            }

            else if (rndNumb == 77)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital do Egito?";
                btnOpcao1.Text = "Cairo";
                btnOpcao2.Text = "Alexandria";
                btnOpcao3.Text = "Giza";
                btnOpcao4.Text = "Luxor";
            }

            else if (rndNumb == 78)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'O Retrato de Dorian Gray'?";
                btnOpcao1.Text = "Oscar Wilde";
                btnOpcao2.Text = "Emily Brontë";
                btnOpcao3.Text = "Charlotte Brontë";
                btnOpcao4.Text = "Jane Austen";
            }

            else if (rndNumb == 79)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital da Turquia?";
                btnOpcao1.Text = "Istambul";
                btnOpcao2.Text = "Ancara";
                btnOpcao3.Text = "Antália";
                btnOpcao4.Text = "Esmirna";
            }

            else if (rndNumb == 80)
            {
                cont++;
                lblPergunta.Text = "Qual é o maior estado dos Estados Unidos em área?";
                btnOpcao1.Text = "Montana";
                btnOpcao2.Text = "Alasca";
                btnOpcao3.Text = "Califórnia";
                btnOpcao4.Text = "Texas";
            }

            else if (rndNumb == 81)
            {
                cont++;
                lblPergunta.Text = "Quem foi o autor de 'Cem Anos de Solidão'?";
                btnOpcao1.Text = "Gabriel García Márquez";
                btnOpcao2.Text = "Mario Vargas Llosa";
                btnOpcao3.Text = "Julio Cortázar";
                btnOpcao4.Text = "Pablo Neruda";
            }

            else if (rndNumb == 82)
            {
                cont++;
                lblPergunta.Text = "Qual é o país com a maior área territorial do mundo?";
                btnOpcao1.Text = "China";
                btnOpcao2.Text = "Rússia"; 
                btnOpcao3.Text = "Canadá";
                btnOpcao4.Text = "Estados Unidos";
            }

            else if (rndNumb == 83)
            {
                cont++;
                lblPergunta.Text = "Quem pintou 'A Persistência da Memória'?";
                btnOpcao1.Text = "Pablo Picasso";
                btnOpcao2.Text = "Vincent van Gogh";
                btnOpcao3.Text = "Salvador Dalí";
                btnOpcao4.Text = "Claude Monet";
            }

            else if (rndNumb == 84)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'A Revolução dos Bichos'?";
                btnOpcao1.Text = "George Orwell";
                btnOpcao2.Text = "Aldous Huxley";
                btnOpcao3.Text = "Ray Bradbury";
                btnOpcao4.Text = "H.G. Wells";
            }

            else if (rndNumb == 85)
            {
                cont++;
                lblPergunta.Text = "Qual é o único metal líquido em temperatura ambiente?";
                btnOpcao1.Text = "Cobre";
                btnOpcao2.Text = "Prata";
                btnOpcao3.Text = "Mercúrio";
                btnOpcao4.Text = "Ouro";
            }

            else if (rndNumb == 86)
            {
                cont++;
                lblPergunta.Text = "Quem foi o primeiro homem a escalar o Monte Everest?";
                btnOpcao1.Text = "Tenzing Norgay";
                btnOpcao2.Text = "Edmund Hillary";
                btnOpcao3.Text = "Reinhold Messner";
                btnOpcao4.Text = "George Mallory";
            }

            else if (rndNumb == 87)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital da Rússia?";
                btnOpcao1.Text = "São Petersburgo";
                btnOpcao2.Text = "Moscou";
                btnOpcao3.Text = "Kiev";
                btnOpcao4.Text = "Minsk";
            }

            else if (rndNumb == 88)
            {
                cont++;
                lblPergunta.Text = "Quem escreveu 'A Divina Comédia'?";
                btnOpcao1.Text = "William Shakespeare";
                btnOpcao2.Text = "Homer";
                btnOpcao3.Text = "Geoffrey Chaucer";
                btnOpcao4.Text = "Dante Alighieri";
            }

            else if (rndNumb == 89)
            {
                cont++;
                lblPergunta.Text = "Quem foi o autor de '1984'?";
                btnOpcao1.Text = "George Orwell";
                btnOpcao2.Text = "Ray Bradbury";
                btnOpcao3.Text = "Aldous Huxley";
                btnOpcao4.Text = "H.G. Wells";
            }

            else if (rndNumb == 90)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital da Holanda?";
                btnOpcao1.Text = "Roterdã";
                btnOpcao2.Text = "Amsterdã";
                btnOpcao3.Text = "Haia";
                btnOpcao4.Text = "Utrecht";
            }

            else if (rndNumb == 91)
            {
                cont++;
                lblPergunta.Text = "Qual é a capital da Espanha?";
                btnOpcao1.Text = "Barcelona";
                btnOpcao2.Text = "Sevilha";
                btnOpcao3.Text = "Valência";
                btnOpcao4.Text = "Madri";
            }

            else if (rndNumb == 92)
            {
                cont++;
                lblPergunta.Text = "Qual é o desporto mais popular na Índia?";
                btnOpcao1.Text = "Críquete";
                btnOpcao2.Text = "Futebol";
                btnOpcao3.Text = "Hóquei";
                btnOpcao4.Text = "Badminton";
            }

            else if (rndNumb == 93)
            {
                cont++;
                lblPergunta.Text = "Qual é o esporte nacional do Japão?";
                btnOpcao1.Text = "Judô";
                btnOpcao2.Text = "Sumô";
                btnOpcao3.Text = "Karatê";
                btnOpcao4.Text = "Beisebol";
            }

            else if (rndNumb == 94)
            {
                cont++;
                lblPergunta.Text = "Qual é o desporto mais popular na Argentina?";
                btnOpcao1.Text = "Rugby";
                btnOpcao2.Text = "Pólo";
                btnOpcao3.Text = "Futebol";
                btnOpcao4.Text = "Basquete";
            }

            else if (rndNumb == 95)
            {
                cont++;
                lblPergunta.Text = "Quantos pontos vale um touchdown no futebol americano?";
                btnOpcao1.Text = "3";
                btnOpcao2.Text = "6";
                btnOpcao3.Text = "7";
                btnOpcao4.Text = "1";
            }

            else if (rndNumb == 96)
            {
                cont++;
                lblPergunta.Text = "Qual jogador de futebol é conhecido como 'O Fenômeno'?";
                btnOpcao1.Text = "Lionel Messi";
                btnOpcao2.Text = "Neymar Jr.";
                btnOpcao3.Text = "Cristiano Ronaldo";
                btnOpcao4.Text = "Ronaldo Nazário";
            }

            else if (rndNumb == 97)
            {
                cont++;
                lblPergunta.Text = "Quem é o criador da série de filmes 'Toy Story'?";
                btnOpcao1.Text = "Steven Spielberg";
                btnOpcao2.Text = "Tim Burton";
                btnOpcao3.Text = "Pixar";
                btnOpcao4.Text = "DreamWorks";
            }

            else if (rndNumb == 98)
            {
                cont++;
                lblPergunta.Text = "Qual é o nome do dragão em 'Shrek'?";
                btnOpcao1.Text = "Fiona";
                btnOpcao2.Text = "Donkey";
                btnOpcao3.Text = "Puss in Boots";
                btnOpcao4.Text = "Dragon";
            }

            else if (rndNumb == 99)
            {
                cont++;
                lblPergunta.Text = "Qual filme de animação ganhou o Oscar de Melhor Filme em 2003?";
                btnOpcao1.Text = "Monstros S.A.";
                btnOpcao2.Text = "Toy Story 2";
                btnOpcao3.Text = "Procurando Nemo";
                btnOpcao4.Text = "Shrek";
            }

            else if (rndNumb == 100)
            {
                cont++;
                lblPergunta.Text = "Qual filme de animação é ambientado na cidade de Radiator Springs?";
                btnOpcao1.Text = "Carros";
                btnOpcao2.Text = "Monstros S.A.";
                btnOpcao3.Text = "Toy Story";
                btnOpcao4.Text = "Procurando Nemo";
            }

            else if (rndNumb == 101)
            {
                cont++;
                lblPergunta.Text = "Quem é o criador da empresa SpaceX e Tesla?";
                btnOpcao1.Text = "Mark Zuckerberg";
                btnOpcao2.Text = "Jeff Bezos";
                btnOpcao3.Text = "Elon Musk";
                btnOpcao4.Text = "Bill Gates";
            }

            else if (rndNumb == 102)
            {
                cont++;
                lblPergunta.Text = "Quem é conhecido como o 'Rei do Pop'?";
                btnOpcao1.Text = "Prince";
                btnOpcao2.Text = "Michael Jackson";
                btnOpcao3.Text = "Elvis Presley";
                btnOpcao4.Text = "David Bowie";
            }

            else if (rndNumb == 103)
            {
                cont++;
                lblPergunta.Text = "Quem é a autora do livro 'Orgulho e Preconceito'?";
                btnOpcao1.Text = "Emily Brontë";
                btnOpcao2.Text = "Charlotte Brontë";
                btnOpcao3.Text = "Jane Austen";
                btnOpcao4.Text = "Louisa May Alcott";
            }

            else if (rndNumb == 104)
            {
                cont++;
                lblPergunta.Text = "Quem foi o líder do movimento pelos direitos civis nos Estados Unidos?";
                btnOpcao1.Text = "Malcolm X";
                btnOpcao2.Text = "Martin Luther King Jr.";
                btnOpcao3.Text = "Nelson Mandela";
                btnOpcao4.Text = "Rosa Parks";
            }

            else if (rndNumb == 105)
            {
                cont++;
                lblPergunta.Text = "Quem é considerado o maior jogador de basquetebol de todos os tempos?";
                btnOpcao1.Text = "Kobe Bryant";
                btnOpcao2.Text = "LeBron James";
                btnOpcao3.Text = "Magic Johnson";
                btnOpcao4.Text = "Michael Jordan";
            }

            else if (rndNumb == 106)
            {
                cont++;
                lblPergunta.Text = "Quem é o criador da série de filmes 'Star Wars'?";
                btnOpcao1.Text = "Steven Spielberg";
                btnOpcao2.Text = "James Cameron";
                btnOpcao3.Text = "George Lucas";
                btnOpcao4.Text = "Peter Jackson";
            }

            else if (rndNumb == 107)
            {
                cont++;
                lblPergunta.Text = "Quem é conhecido como 'The Queen of Pop'?";
                btnOpcao1.Text = "Madonna";
                btnOpcao2.Text = "Lady Gaga";
                btnOpcao3.Text = "Beyoncé";
                btnOpcao4.Text = "Rihanna";
            }

            else if (rndNumb == 108)
            {
                cont++;
                lblPergunta.Text = "Quem foi o líder político sul-africano e vencedor do Prêmio Nobel da Paz?";
                btnOpcao1.Text = "Nelson Mandela";
                btnOpcao2.Text = "Desmond Tutu";
                btnOpcao3.Text = "F.W. de Klerk";
                btnOpcao4.Text = "Thabo Mbeki";
            }

            else if (rndNumb == 109)
            {
                cont++;
                lblPergunta.Text = "Quem é considerado o fundador do Facebook?";
                btnOpcao1.Text = "Bill Gates";
                btnOpcao2.Text = "Mark Zuckerberg";
                btnOpcao3.Text = "Steve Jobs";
                btnOpcao4.Text = "Jeff Bezos";
            }

            else if (rndNumb == 110)
            {
                cont++;
                lblPergunta.Text = "Quem foi o líder da Revolução Cubana?";
                btnOpcao1.Text = "Che Guevara";
                btnOpcao2.Text = "Augusto Pinochet";
                btnOpcao3.Text = "Hugo Chávez";
                btnOpcao4.Text = "Fidel Castro";
            }

            else if (rndNumb == 111)
            {
                cont++;
                lblPergunta.Text = "Quem é o autor de 'A Origem das Espécies'?";
                btnOpcao1.Text = "Charles Darwin";
                btnOpcao2.Text = "Gregor Mendel";
                btnOpcao3.Text = "Louis Pasteur";
                btnOpcao4.Text = "Isaac Newton";
            }

            else if (rndNumb == 112)
            {
                cont++;
                lblPergunta.Text = "Quem foi o presidente dos Estados Unidos durante a Guerra Civil Americana?";
                btnOpcao1.Text = "Thomas Jefferson";
                btnOpcao2.Text = "George Washington";
                btnOpcao3.Text = "Abraham Lincoln";
                btnOpcao4.Text = "Andrew Jackson";
            }

            else if (rndNumb == 113)
            {
                cont++;
                lblPergunta.Text = "Quem é a autora do livro 'Frankenstein'?";
                btnOpcao1.Text = "Emily Brontë";
                btnOpcao2.Text = "Jane Austen";
                btnOpcao3.Text = "Mary Shelley";
                btnOpcao4.Text = "Louisa May Alcott";
            }

            else if (rndNumb == 114)
            {
                cont++;
                lblPergunta.Text = "Quem é conhecido como o 'Rei do Rock'n'Roll'?";
                btnOpcao1.Text = "Elvis Presley";
                btnOpcao2.Text = "Chuck Berry";
                btnOpcao3.Text = "Buddy Holly";
                btnOpcao4.Text = "Jerry Lee Lewis";
            }

            else if (rndNumb == 115)
            {
                cont++;
                lblPergunta.Text = "Quem é considerado o maior gênio da história da humanidade?";
                btnOpcao1.Text = "Vincent van Gogh";
                btnOpcao2.Text = "Michelangelo";
                btnOpcao3.Text = "Pablo Picasso";
                btnOpcao4.Text = "Leonardo da Vinci";
            }

            else if (rndNumb == 116)
            {
                cont++;
                lblPergunta.Text = "Quem é considerado o maior escritor da língua inglesa?";
                btnOpcao1.Text = "William Shakespeare";
                btnOpcao2.Text = "Charles Dickens";
                btnOpcao3.Text = "Jane Austen";
                btnOpcao4.Text = "Emily Brontë";
            }

            else if (rndNumb == 117)
            {
                cont++;
                lblPergunta.Text = "Quem é conhecido como o 'Rei do Reggae'?";
                btnOpcao1.Text = "Bob Dylan";
                btnOpcao2.Text = "Bob Marley";
                btnOpcao3.Text = "Peter Tosh";
                btnOpcao4.Text = "Jimmy Cliff";
            }

            else if (rndNumb == 118)
            {
                cont++;
                lblPergunta.Text = "Quem é o criador da empresa Microsoft?";
                btnOpcao1.Text = "Steve Jobs";
                btnOpcao2.Text = "Bill Gates";
                btnOpcao3.Text = "Mark Zuckerberg";
                btnOpcao4.Text = "Larry Page";
            }

            else if (rndNumb == 119)
            {
                cont++;
                lblPergunta.Text = "Quem é conhecido como 'O Mago'?";
                btnOpcao1.Text = "Merlin";
                btnOpcao2.Text = "Harry Houdini";
                btnOpcao3.Text = "David Copperfield";
                btnOpcao4.Text = "Aleister Crowley";
            }

            else if (rndNumb == 120)
            {
                cont++;
                lblPergunta.Text = "Quem é a atriz que interpretou Hermione Granger nos filmes da série 'Harry Potter'?";
                btnOpcao1.Text = "Emma Thompson";
                btnOpcao2.Text = "Emma Stone";
                btnOpcao3.Text = "Emma Watson";
                btnOpcao4.Text = "Emma Roberts";
            }

            else if (rndNumb == 121)
            {
                cont++;
                lblPergunta.Text = "Quem é conhecido como o 'Rei do Futebol'?";
                btnOpcao1.Text = "Pelé";
                btnOpcao2.Text = "Diego Maradona";
                btnOpcao3.Text = "Lionel Messi";
                btnOpcao4.Text = "Cristiano Ronaldo";
            }

            else if (rndNumb == 122)
            {
                cont++;
                lblPergunta.Text = "Quem foi o primeiro astronauta a pisar na Lua?";
                btnOpcao1.Text = "Buzz Aldrin";
                btnOpcao2.Text = "Neil Armstrong";
                btnOpcao3.Text = "Yuri Gagarin";
                btnOpcao4.Text = "John Glenn";
            }
        }

        private void opcaoGanhou()
        {
            timer.Stop();
            classeMusica.musicaCerto();
            lblSaldo2.Text = (FrmMain.aposta + "€");
            lblPergunta.Visible = false;
            btnOpcao1.Visible = false;
            btnOpcao2.Visible = false;
            btnOpcao3.Visible = false;
            btnOpcao4.Visible = false;
            lblSaldo.Visible = false;
            lblPergunta2.Visible = false;
            btnContinuar.Visible = true;
            btnDesistir.Visible = false;
            btnVitoria.Visible = false;
            btnSair.Visible = false;
            lblPerdeu.Visible = false;
            lblSaldo2.Visible = true;
            lblCerto.Visible = true;
            lblGanhou.Visible = false;

            
            perguntasGeradas();
        }
        
        private void opcaoPerdeu()
        {
            timer.Stop();
            classeMusica.musicaErrado();
            lblSaldo2.Text = (FrmMain.aposta * 0 + "€");
            lblSaldo2.BackColor = Color.Red;

            lblPergunta.Visible = false;
            btnOpcao1.Visible = false;
            btnOpcao2.Visible = false;
            btnOpcao3.Visible = false;
            btnOpcao4.Visible = false;
            lblSaldo.Visible = false;
            lblPergunta2.Visible = false;
            btnContinuar.Visible = false;
            btnDesistir.Visible = false;
            btnVitoria.Visible = false;
            btnSair.Visible = true;
            lblPerdeu.Visible = true;
            lblSaldo2.Visible = true;
            lblGanhou.Visible = false;
        }

        private void tempo(object sender, EventArgs e)
        {
            timer.Stop();
            classeMusica.musicaErrado();

            lblSaldo2.Text = (FrmMain.aposta * 0 + "€");
            lblSaldo2.BackColor = Color.Red;
            lblPergunta.Visible = false;
            btnOpcao1.Visible = false;
            btnOpcao2.Visible = false;
            btnOpcao3.Visible = false;
            btnOpcao4.Visible = false;
            lblSaldo.Visible = false;
            lblPergunta2.Visible = false;
            btnContinuar.Visible = false;
            btnDesistir.Visible = false;
            btnVitoria.Visible = false;
            btnSair.Visible = true;
            lblPerdeu.Visible = true;
            lblSaldo2.Visible = true;
            lblGanhou.Visible = false;
        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {
            if (rndNumb == 1)
            {
                opcaoPerdeu();

            }

            else if (rndNumb == 2)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 3)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 4)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 5)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 6)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 7)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 8)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 9)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 10)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 11)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 12)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 13)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 14)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 15)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 16)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 17)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 18)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 19)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 20)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 21)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 22)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 23)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 24)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 25)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 26)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 27)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 28)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 29)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 30)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 31)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 32)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 33)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 34)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 35)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 36)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 37)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 38)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 39)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 40)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 41)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 42)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 43)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 44)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 45)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 46)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 47)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 48)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 49)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 50)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 51)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 52)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 53)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 54)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 55)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 56)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 57)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 58)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 59)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 60)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 61)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 62)
            {
                opcaoGanhou(); ;
            }

            else if (rndNumb == 63)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 64)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 65)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 66)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 67)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 68)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 69)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 70)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 71)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 72)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 73)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 74)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 75)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 76)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 77)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 78)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 79)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 80)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 81)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 82)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 83)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 84)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 85)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 86)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 87)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 88)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 89)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 90)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 91)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 92)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 93)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 94)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 95)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 96)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 97)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 98)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 99)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 100)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 101)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 102)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 103)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 104)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 105)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 106)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 107)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 108)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 109)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 110)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 111)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 112)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 113)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 114)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 115)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 116)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 117)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 118)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 119)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 120)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 121)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 122)
            {
                opcaoPerdeu();
            }
        }

        private void btnOpcao2_Click(object sender, EventArgs e)
        {
            if (rndNumb == 1)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 2)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 3)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 4)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 5)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 6)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 7)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 8)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 9)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 10)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 11)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 12)
            {
                opcaoGanhou();

            }

            else if (rndNumb == 13)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 14)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 15)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 16)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 17)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 18)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 19)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 20)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 21)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 22)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 23)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 24)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 25)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 26)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 27)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 28)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 29)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 30)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 31)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 32)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 33)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 34)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 35)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 36)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 37)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 38)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 39)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 40)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 41)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 42)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 43)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 44)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 45)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 46)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 47)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 48)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 49)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 50)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 51)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 52)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 53)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 54)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 55)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 56)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 57)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 58)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 59)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 60)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 61)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 62)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 63)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 64)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 65)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 66)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 67)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 68)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 69)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 70)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 71)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 72)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 73)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 74)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 75)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 76)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 77)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 78)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 79)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 80)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 81)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 82)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 83)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 84)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 85)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 86)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 87)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 88)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 89)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 90)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 91)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 92)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 93)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 94)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 95)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 96)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 97)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 98)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 99)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 100)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 101)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 102)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 103)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 104)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 105)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 106)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 107)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 108)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 109)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 110)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 111)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 112)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 113)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 114)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 115)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 116)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 117)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 118)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 119)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 120)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 121)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 122)
            {
                opcaoGanhou();
            }
        }

        private void btnOpcao3_Click(object sender, EventArgs e)
        {
            if (rndNumb == 1)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 2)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 3)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 4)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 5)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 6)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 7)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 8)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 9)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 10)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 11)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 12)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 13)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 14)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 15)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 16)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 17)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 18)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 19)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 20)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 21)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 22)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 23)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 24)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 25)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 26)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 27)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 28)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 29)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 30)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 31)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 32)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 33)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 34)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 35)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 36)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 37)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 38)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 39)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 40)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 41)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 42)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 43)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 44)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 45)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 46)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 47)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 48)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 49)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 50)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 51)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 52)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 53)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 54)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 55)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 56)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 57)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 58)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 59)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 60)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 61)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 62)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 63)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 64)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 65)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 66)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 67)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 68)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 69)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 70)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 71)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 72)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 73)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 74)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 75)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 76)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 77)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 78)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 79)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 80)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 81)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 82)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 83)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 84)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 85)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 86)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 87)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 88)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 89)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 90)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 91)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 92)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 93)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 94)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 95)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 96)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 97)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 98)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 99)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 100)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 101)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 102)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 103)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 104)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 105)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 106)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 107)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 108)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 109)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 110)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 111)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 112)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 113)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 114)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 115)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 116)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 117)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 118)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 119)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 120)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 121)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 122)
            {
                opcaoPerdeu();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaResponder();
            timer.Start();
            lblPergunta.Visible = true;
            btnOpcao1.Visible = true;
            btnOpcao2.Visible = true;
            btnOpcao3.Visible = true;
            btnOpcao4.Visible = true;
            lblSaldo.Visible = true;
            lblPergunta2.Visible = false;
            btnContinuar.Visible = false;
            btnDesistir.Visible = false;
            btnSair.Visible = false;
            lblSaldo2.Visible = false;
            btnVitoria.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            FrmMain.aposta = 0;
            this.Close();
            FrmMilionario m = new FrmMilionario();
            m.Show();
        }

        private void btnDesistir_Click(object sender, EventArgs e)
        {
            FrmMain.saldo += FrmMain.aposta;
            classeMusica.musicaSair();
            this.Close();
            FrmMilionario m = new FrmMilionario();
            m.Show();
        }

        private void btnVitoria_Click(object sender, EventArgs e)
        {
            FrmMain.saldo += FrmMain.aposta;
            classeMusica.musicaSair();
            this.Close();
            FrmMilionario m = new FrmMilionario();
            m.Show();
        }

        private void btnOpcao4_Click_1(object sender, EventArgs e)
        {
            if (rndNumb == 1)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 2)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 3)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 4)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 5)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 6)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 7)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 8)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 9)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 10)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 11)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 12)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 13)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 14)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 15)
            {
                opcaoGanhou();

            }

            else if (rndNumb == 16)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 17)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 18)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 19)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 20)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 21)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 22)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 23)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 24)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 25)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 26)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 27)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 28)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 29)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 30)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 31)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 32)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 33)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 34)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 35)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 36)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 37)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 38)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 39)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 40)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 41)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 42)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 43)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 44)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 45)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 46)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 47)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 48)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 49)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 50)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 51)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 52)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 53)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 54)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 55)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 56)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 57)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 58)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 59)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 60)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 61)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 62)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 63)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 64)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 65)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 66)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 67)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 68)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 69)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 70)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 71)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 72)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 73)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 74)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 75)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 76)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 77)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 78)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 79)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 80)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 81)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 82)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 83)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 84)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 85)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 86)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 87)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 88)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 89)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 90)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 91)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 92)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 93)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 94)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 95)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 96)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 97)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 98)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 99)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 100)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 101)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 102)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 103)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 104)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 105)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 106)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 107)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 108)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 109)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 110)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 111)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 112)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 113)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 114)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 115)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 116)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 117)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 118)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 119)
            {
                opcaoGanhou();
            }

            else if (rndNumb == 120)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 121)
            {
                opcaoPerdeu();
            }

            else if (rndNumb == 122)
            {
                opcaoPerdeu();
            }
        }
    }
}
