using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDoMilhao
{
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }

        #region Variáveis Globais

        int segundo = 60, rodada = 1, randomPergunta, indiceAlternativa, ajuda1, ajuda2;
        String [] perguntas, respostas, 
            alternativas1, alternativas2, alternativas3, alternativas4,
            ajudas1, ajudas2;
        string resposta, acertar, parar, errar;
        string msg, titulo;

        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;

        List<Button> buttons = new List<Button>();

        #endregion

        #region Seguir
        public void Seguir()
        {
            rodada++;

            switch (rodada)
            {
                case 2:
                    Rodada2();
                    SelecionaPergunta();
                    break;
                case 3:
                    Rodada3();
                    SelecionaPergunta();
                    break;
                case 4:
                    Rodada4();
                    SelecionaPergunta();
                    break;
                case 5:
                    Rodada5();
                    SelecionaPergunta();
                    break;
                case 6:
                    Rodada6();
                    SelecionaPergunta();
                    break;
                case 7:
                    Rodada7();
                    SelecionaPergunta();
                    break;

            }

        }
        #endregion

        #region Seleciona Pergunta
        public void SelecionaPergunta()
        {
            Random random = new Random();
            randomPergunta = random.Next(6);
            lblPergunta.Text = perguntas[randomPergunta];
            resposta = respostas[randomPergunta];
            btnAlternativa1.Text = alternativas1[randomPergunta];
            btnAlternativa2.Text = alternativas2[randomPergunta];
            btnAlternativa3.Text = alternativas3[randomPergunta];
            btnAlternativa4.Text = alternativas4[randomPergunta];
            ajuda1 = Convert.ToInt32(ajudas1[randomPergunta]);
            ajuda2 = Convert.ToInt32(ajudas2[randomPergunta]);
        }
        #endregion

        #region Alternativas
        private void btnAlternativa1_Click(object sender, EventArgs e)
        {
            indiceAlternativa = 0;
            Resposta();
        }

        private void btnAlternativa2_Click(object sender, EventArgs e)
        {
            indiceAlternativa = 1;
            Resposta();
        }

        private void btnAlternativa3_Click(object sender, EventArgs e)
        {
            indiceAlternativa = 2;
            Resposta();
        }

        private void btnAlternativa4_Click(object sender, EventArgs e)
        {
            indiceAlternativa = 3;
            Resposta();
        }
        #endregion

        #region Agrupa Botões
        public void AgrupaBotoes()
        {
            buttons.Add(btnAlternativa1);
            buttons.Add(btnAlternativa2);
            buttons.Add(btnAlternativa3);
            buttons.Add(btnAlternativa4);
        }
        #endregion

        #region Resposta
        public void Resposta()
        {
            timer1.Enabled = false;
            AgrupaBotoes();

            if (buttons[indiceAlternativa].Text == resposta)
            {
                if (rodada < 6) {
                    msg = "PARABÉNS! AGORA AVANCE PARA PRÓXIMA RODADA!";
                    titulo = "ACERTOU!";
                    botoes = MessageBoxButtons.OK;
                    icone = MessageBoxIcon.Exclamation;
                    definido = MessageBoxDefaultButton.Button1;
                    if(MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                    {
                        Seguir();
                    }
                }
                else if (rodada == 6)
                {
                    msg = "PARABÉNS! SE VOCÊ ESCOLHER AVANÇAR AGORA, NÃO PODERÁ DESISTIR. DESEJA AVANÇAR?";
                    titulo = "ACERTOU!";
                    botoes = MessageBoxButtons.YesNo;
                    icone = MessageBoxIcon.Exclamation;
                    definido = MessageBoxDefaultButton.Button1;
                    if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
                    {
                        Seguir();
                    }
                    else
                    {
                        msg = "PARABÉNS! VOCÊ FICOU COM 500MIL PONTOS";
                        titulo = "";
                        botoes = MessageBoxButtons.OK;
                        icone = MessageBoxIcon.Exclamation;
                        definido = MessageBoxDefaultButton.Button1;
                        if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    msg = "VOCÊ VENCEU! PARABÉNS PELO PRÊMIO DE 1MILHÃO DE PONTOS!";
                    titulo = "ACERTOU!";
                    botoes = MessageBoxButtons.OK;
                    icone = MessageBoxIcon.Exclamation;
                    definido = MessageBoxDefaultButton.Button1;
                    if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else if (buttons[indiceAlternativa].Text != resposta && rodada == 7)
            {
                msg = "QUE PENA... VOCÊ PERDEU TUDO!";
                titulo = "ERROU!";
                botoes = MessageBoxButtons.OK;
                icone = MessageBoxIcon.Error;
                definido = MessageBoxDefaultButton.Button1;
                if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                msg = "QUE PENA... VOCÊ FICOU COM " + errar + " PONTOS!";
                titulo = "ERROU!";
                botoes = MessageBoxButtons.OK;
                icone = MessageBoxIcon.Error;
                definido = MessageBoxDefaultButton.Button1;
                if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        #endregion

        #region Load
        private void FormJogo_Load(object sender, EventArgs e)
        {
            btnAjuda.Enabled = true;
            Rodada1();
            SelecionaPergunta();

        }
        #endregion

        #region Rodada 1
        public void Rodada1()
        {
            segundo = 60;
            errar = "ZERO";
            parar = "ZERO";
            acertar = "1MIL";
            timer1.Enabled = true;
            btnAlternativa1.Enabled = true;
            btnAlternativa2.Enabled = true;
            btnAlternativa3.Enabled = true;
            btnAlternativa4.Enabled = true;
            lblErrar.Text = errar;
            lblAcertar.Text = acertar;

            perguntas = new String[6];
            respostas = new String[6];
            alternativas1 = new String[6];
            alternativas2 = new String[6];
            alternativas3 = new String[6];
            alternativas4 = new String[6];
            ajudas1 = new String[6];
            ajudas2 = new String[6];

            perguntas[0] = "A sigla de Instituto Brasileiro de Geografia e Estatística, é:";
            respostas[0] = "IBGE";
            alternativas1[0] = "IBGE";
            alternativas2[0] = "ONU";
            alternativas3[0] = "IB";
            alternativas4[0] = "IBG";
            ajudas1[0] = "1";
            ajudas2[0] = "2";

            perguntas[1] = "Qual nome é dado a “barriga” da perna?";
            respostas[1] = "Panturrilha";
            alternativas1[1] = "Bíceps";
            alternativas2[1] = "Músculo";
            alternativas3[1] = "Panturrilha";
            alternativas4[1] = "Agulha";
            ajudas1[1] = "1";
            ajudas2[1] = "3";

            perguntas[2] = "No futebol, como é chamado o jogador que usa uma\n" +
                "braçadeira?";
            respostas[2] = "Capitão";
            alternativas1[2] = "Gandula";
            alternativas2[2] = "Goleiro";
            alternativas3[2] = "Juiz";
            alternativas4[2] = "Capitão";
            ajudas1[2] = "0";
            ajudas2[2] = "1";

            perguntas[3] = "O que a Cinderela perdeu quando saiu do baile?";
            respostas[3] = "Sapato";
            alternativas1[3] = "Sapato";
            alternativas2[3] = "Brinco";
            alternativas3[3] = "Bolsa";
            alternativas4[3] = "Maquiagem";
            ajudas1[3] = "2";
            ajudas2[3] = "3";

            perguntas[4] = "Qual é o coletivo de cães?";
            respostas[4] = "Matilha";
            alternativas1[4] = "Matilha";
            alternativas2[4] = "Rebanho";
            alternativas3[4] = "Alcateia";
            alternativas4[4] = "Manada";
            ajudas1[4] = "1";
            ajudas2[4] = "3";

            perguntas[5] = "Como é chamada a mulher que faz ou vende doces?";
            respostas[5] = "Doceira";
            alternativas1[5] = "Doceira";
            alternativas2[5] = "Parteira";
            alternativas3[5] = "Bordadeira";
            alternativas4[5] = "Rendeira";
            ajudas1[5] = "1";
            ajudas2[5] = "2";
        }
        #endregion

        #region Rodada 2
        public void Rodada2()
        {
            segundo = 60;
            errar = "500";
            parar = "1MIL";
            acertar = "5MIL";
            timer1.Enabled = true;
            btnAlternativa1.Enabled = true;
            btnAlternativa2.Enabled = true;
            btnAlternativa3.Enabled = true;
            btnAlternativa4.Enabled = true;
            lblErrar.Text = errar;
            lblAcertar.Text = acertar;

            perguntas = new String[6];
            respostas = new String[6];
            alternativas1 = new String[6];
            alternativas2 = new String[6];
            alternativas3 = new String[6];
            alternativas4 = new String[6];
            ajudas1 = new String[6];
            ajudas2 = new String[6];

            perguntas[0] = "Qual bicho transmite a Doença de Chagas?";
            respostas[0] = "Barbeiro";
            alternativas1[0] = "Pulga";
            alternativas2[0] = "Mosquito";
            alternativas3[0] = "Barata";
            alternativas4[0] = "Barbeiro";
            ajudas1[0] = "0";
            ajudas2[0] = "2";

            perguntas[1] = "Segundo a tradição da religião cristã, \n" +
                "quais presentes os três reis magos entregaram\n" +
                "para o menino Jesus?";
            respostas[1] = "Ouro, incenso e mirra";
            alternativas1[1] = "Ouro, prata e bronze";
            alternativas2[1] = "Ouro, incenso e mirra";
            alternativas3[1] = "Ouro, incenso e comida";
            alternativas4[1] = "Ouro, brinquedo e mirra ";
            ajudas1[1] = "0";
            ajudas2[1] = "3";

            perguntas[2] = "Qual é a área da medicina especializada em crianças?";
            respostas[2] = "Pediatria";
            alternativas1[2] = "Geriatria";
            alternativas2[2] = "Pediatria";
            alternativas3[2] = "Infantologia";
            alternativas4[2] = "Biologia";
            ajudas1[2] = "0";
            ajudas2[2] = "3";

            perguntas[3] = "Qual é a linha que separa o planeta em dois hemisférios?";
            respostas[3] = "Linha do Equador";
            alternativas1[3] = "Linha Siegried";
            alternativas2[3] = "Linha do Equador";
            alternativas3[3] = "Linha Curzon";
            alternativas4[3] = "Linha Maginot";
            ajudas1[3] = "0";
            ajudas2[3] = "2";

            perguntas[4] = "Qual é o triângulo que tem todos o lados diferentes?";
            respostas[4] = "Escaleno";
            alternativas1[4] = "Equilátero";
            alternativas2[4] = "Isóceles";
            alternativas3[4] = "Escaleno";
            alternativas4[4] = "Trapézio";
            ajudas1[4] = "1";
            ajudas2[4] = "3";

            perguntas[5] = "Que estúdio produziu o filme Aladdin?";
            respostas[5] = "Disney";
            alternativas1[5] = "Paramount";
            alternativas2[5] = "Projac";
            alternativas3[5] = "Disney";
            alternativas4[5] = "Recnov";
            ajudas1[5] = "1";
            ajudas2[5] = "3";
        }
        #endregion

        #region Rodada 3
        public void Rodada3()
        {
            segundo = 60;
            errar = "2,5MIL";
            parar = "5MIL";
            acertar = "10MIL";
            timer1.Enabled = true;
            btnAlternativa1.Enabled = true;
            btnAlternativa2.Enabled = true;
            btnAlternativa3.Enabled = true;
            btnAlternativa4.Enabled = true;
            lblErrar.Text = errar;
            lblAcertar.Text = acertar;

            perguntas = new String[6];
            respostas = new String[6];
            alternativas1 = new String[6];
            alternativas2 = new String[6];
            alternativas3 = new String[6];
            alternativas4 = new String[6];
            ajudas1 = new String[6];
            ajudas2 = new String[6];

            perguntas[0] = "Quantos metros uma jibóia pode chegar a medir?";
            respostas[0] = "4,5";
            alternativas1[0] = "4,5";
            alternativas2[0] = "4";
            alternativas3[0] = "3,5";
            alternativas4[0] = "3";
            ajudas1[0] = "2";
            ajudas2[0] = "3";

            perguntas[1] = "Complete a música do Cazuza “Brasil! Mostra tua cara\n" +
                "quero ver quem ____ pra gente ficar assim”";
            respostas[1] = "Paga";
            alternativas1[1] = "Paga";
            alternativas2[1] = "Rouba";
            alternativas3[1] = "Chega";
            alternativas4[1] = "Pega";
            ajudas1[1] = "1";
            ajudas2[1] = "2";

            perguntas[2] = "O que é inclinação?";
            respostas[2] = "Desvio da Direção Perpendicular";
            alternativas1[2] = "Desvio da Direção Lunar";
            alternativas2[2] = "Desvio da Direção Solar";
            alternativas3[2] = "Desvio da Direção Circular";
            alternativas4[2] = "Desvio da Direção Perpendicular";
            ajudas1[2] = "0";
            ajudas2[2] = "1";

            perguntas[3] = "A semana de arte moderna de 1922 ocorreu em qual\n" +
                "cidade do Brasil?";
            respostas[3] = "São Paulo";
            alternativas1[3] = "Salvador";
            alternativas2[3] = "Recife";
            alternativas3[3] = "São Paulo";
            alternativas4[3] = "Rio de Janeiro";
            ajudas1[3] = "0";
            ajudas2[3] = "3";

            perguntas[4] = "Qual é a unidade de medida de corrente elétrica?";
            respostas[4] = "Ampere";
            alternativas1[4] = "Metro";
            alternativas2[4] = "Quilograma";
            alternativas3[4] = "Segundo";
            alternativas4[4] = "Ampere";
            ajudas1[4] = "0";
            ajudas2[4] = "1";

            perguntas[5] = "Seguindo a sequência do baralho, qual carta vem\n" +
                "depois do dez?";
            respostas[5] = "Valete";
            alternativas1[5] = "Rei";
            alternativas2[5] = "Valete";
            alternativas3[5] = "Dama";
            alternativas4[5] = "Ás";
            ajudas1[5] = "0";
            ajudas2[5] = "3";
        }
        #endregion

        #region Rodada 4
        public void Rodada4()
        {
            segundo = 60;
            errar = "5MIL";
            parar = "10MIL";
            acertar = "50MIL";
            timer1.Enabled = true;
            btnAlternativa1.Enabled = true;
            btnAlternativa2.Enabled = true;
            btnAlternativa3.Enabled = true;
            btnAlternativa4.Enabled = true;
            lblErrar.Text = errar;
            lblAcertar.Text = acertar;

            perguntas = new String[6];
            respostas = new String[6];
            alternativas1 = new String[6];
            alternativas2 = new String[6];
            alternativas3 = new String[6];
            alternativas4 = new String[6];
            ajudas1 = new String[6];
            ajudas2 = new String[6];

            perguntas[0] = "Ata e Pinha são nomes diferentes que se referem\n" +
                "a qual fruta?";
            respostas[0] = "Fruta do Conde";
            alternativas1[0] = "Kiwi";
            alternativas2[0] = "Pêra";
            alternativas3[0] = "Fruta do Conde";
            alternativas4[0] = "Abacaxi";
            ajudas1[0] = "1";
            ajudas2[0] = "3";

            perguntas[1] = "Quais elementos formam o latão?";
            respostas[1] = "Cobre e Zinco";
            alternativas1[1] = "Cobre e Zinco";
            alternativas2[1] = "Cobre e Ouro";
            alternativas3[1] = "Zinco e Prata";
            alternativas4[1] = "Ouro e Prata";
            ajudas1[1] = "1";
            ajudas2[1] = "3";

            perguntas[2] = "A cidade de São José de Ribamar fica em que estado?";
            respostas[2] = "Maranhão";
            alternativas1[2] = "Maranhão";
            alternativas2[2] = "Bahia";
            alternativas3[2] = "Piauí";
            alternativas4[2] = "Sergipe";
            ajudas1[2] = "1";
            ajudas2[2] = "2";

            perguntas[3] = "Que dia é comemorada a proclamação da república no\n" +
                "Brasil?";
            respostas[3] = "15 de novembro";
            alternativas1[3] = "19 de abril";
            alternativas2[3] = "15 de outubro";
            alternativas3[3] = "19 de novembro";
            alternativas4[3] = "15 de novembro";
            ajudas1[3] = "0";
            ajudas2[3] = "1";

            perguntas[4] = "Em que país nasceu Carmem Miranda?";
            respostas[4] = "Portugal";
            alternativas1[4] = "Brasil";
            alternativas2[4] = "Espanha";
            alternativas3[4] = "Portugal";
            alternativas4[4] = "Argentina";
            ajudas1[4] = "1";
            ajudas2[4] = "3";

            perguntas[5] = "Qual é o parentesco das personagens Lana e Lara, da\n" +
                "série castelo rá-tim-bum (1994)?";
            respostas[5] = "Irmãs";
            alternativas1[5] = "Primas";
            alternativas2[5] = "Irmãs";
            alternativas3[5] = "Sobrinha e tia";
            alternativas4[5] = "Mãe e filha";
            ajudas1[5] = "2";
            ajudas2[5] = "3";
        }
        #endregion

        #region Rodada 5
        public void Rodada5()
        {
            segundo = 60;
            errar = "25MIL";
            parar = "50MIL";
            acertar = "100MIL";
            timer1.Enabled = true;
            btnAlternativa1.Enabled = true;
            btnAlternativa2.Enabled = true;
            btnAlternativa3.Enabled = true;
            btnAlternativa4.Enabled = true;
            lblErrar.Text = errar;
            lblAcertar.Text = acertar;

            perguntas = new String[6];
            respostas = new String[6];
            alternativas1 = new String[6];
            alternativas2 = new String[6];
            alternativas3 = new String[6];
            alternativas4 = new String[6];
            ajudas1 = new String[6];
            ajudas2 = new String[6];

            perguntas[0] = "Em qual país foi fundada a fabrica de automóveis AUDI?";
            respostas[0] = "Alemanha";
            alternativas1[0] = "Rússia";
            alternativas2[0] = "Costa do Marfim	";
            alternativas3[0] = "Coréia do Sul";
            alternativas4[0] = "Alemanha";
            ajudas1[0] = "1";
            ajudas2[0] = "2";

            perguntas[1] = "A compensação por perda é chamada de...";
            respostas[1] = "Indenização";
            alternativas1[1] = "Déficit";
            alternativas2[1] = "Indenização";
            alternativas3[1] = "Indexação";
            alternativas4[1] = "Indébito";
            ajudas1[1] = "0";
            ajudas2[1] = "3";

            perguntas[2] = "Quem foi o autor do livro Dom Casmurro?";
            respostas[2] = "Machado de Assis";
            alternativas1[2] = "Machado de Assis";
            alternativas2[2] = "Mateus Ceará";
            alternativas3[2] = "Carlos da Nobrega";
            alternativas4[2] = "Luís de Camões";
            ajudas1[2] = "1";
            ajudas2[2] = "2";

            perguntas[3] = "Qual desses objetos está mais relacionado a uma\n" +
                "pinacoteca?";
            respostas[3] = "Quadros";
            alternativas1[3] = "Panelas";
            alternativas2[3] = "Quadros";
            alternativas3[3] = "Garrafas";
            alternativas4[3] = "Telefones";
            ajudas1[3] = "0";
            ajudas2[3] = "3";

            perguntas[4] = "Quem “descobriu” a América?";
            respostas[4] = "Cristóvão Colombo";
            alternativas1[4] = "Pedro Álvares Cabral";
            alternativas2[4] = "Cristóvão Colombo";
            alternativas3[4] = "Pero Vaz de Caminha";
            alternativas4[4] = "Dom Pedro I.";
            ajudas1[4] = "2";
            ajudas2[4] = "3";

            perguntas[5] = "O ano tem 365 dias, já se passaram 98 dias.\n" +
                "Quantos dias faltam para terminar esse ano?";
            respostas[5] = "267";
            alternativas1[5] = "267";
            alternativas2[5] = "265";
            alternativas3[5] = "264";
            alternativas4[5] = "268";
            ajudas1[5] = "1";
            ajudas2[5] = "2";
        }
        #endregion

        #region Rodada 6
        public void Rodada6()
        {
            segundo = 60;
            errar = "50MIL";
            parar = "100MIL";
            acertar = "500MIL";
            timer1.Enabled = true;
            btnAlternativa1.Enabled = true;
            btnAlternativa2.Enabled = true;
            btnAlternativa3.Enabled = true;
            btnAlternativa4.Enabled = true;
            lblErrar.Text = errar;
            lblAcertar.Text = acertar;

            perguntas = new String[6];
            respostas = new String[6];
            alternativas1 = new String[6];
            alternativas2 = new String[6];
            alternativas3 = new String[6];
            alternativas4 = new String[6];
            ajudas1 = new String[6];
            ajudas2 = new String[6];

            perguntas[0] = "Em que ano morreu o cantor brasileiro Raul Seixas?";
            respostas[0] = "1989";
            alternativas1[0] = "1980";
            alternativas2[0] = "1985";
            alternativas3[0] = "1989";
            alternativas4[0] = "1992";
            ajudas1[0] = "0";
            ajudas2[0] = "3";

            perguntas[1] = "Qual fruto é conhecido no Norte e Nordeste como\n" +
                "“jerimum”?";
            respostas[1] = "Abóbora";
            alternativas1[1] = "Caju";
            alternativas2[1] = "Abóbora";
            alternativas3[1] = "Chuchu";
            alternativas4[1] = "Côco";
            ajudas1[1] = "2";
            ajudas2[1] = "3";

            perguntas[2] = "Quem compôs o Hino da Independência?";
            respostas[2] = "Dom Pedro I.";
            alternativas1[2] = "Dom Pedro I.";
            alternativas2[2] = "Manuel Bandeira";
            alternativas3[2] = "Castro Alvez";
            alternativas4[2] = "Carlos Gomes";
            ajudas1[2] = "2";
            ajudas2[2] = "3";

            perguntas[3] = "Quantos municípios compõem o estado do Amapá?";
            respostas[3] = "16";
            alternativas1[3] = "14";
            alternativas2[3] = "15";
            alternativas3[3] = "16";
            alternativas4[3] = "17";
            ajudas1[3] = "0";
            ajudas2[3] = "3";

            perguntas[4] = "O adjetivo “venoso” está relacionado a:";
            respostas[4] = "Veia";
            alternativas1[4] = "Vela";
            alternativas2[4] = "Veno";
            alternativas3[4] = "Vênia";
            alternativas4[4] = "Veia";
            ajudas1[4] = "0";
            ajudas2[4] = "2";

            perguntas[5] = "Qual montanha se localiza entre a fronteira do Tibet\n" +
                "com o Nepal?";
            respostas[5] = "Monte Everest";
            alternativas1[5] = "Monte Everest";
            alternativas2[5] = "Monte Fuji";
            alternativas3[5] = "Monte Carlo";
            alternativas4[5] = "Monte Branco";
            ajudas1[5] = "2";
            ajudas2[5] = "3";
        }
        #endregion

        #region Rodada 7
        public void Rodada7()
        {
            segundo = 60;
            errar = "PERDETUDO";
            acertar = "1MILHÃO";
            timer1.Enabled = true;
            btnAlternativa1.Enabled = true;
            btnAlternativa2.Enabled = true;
            btnAlternativa3.Enabled = true;
            btnAlternativa4.Enabled = true;
            btnAjuda.Enabled = false;
            btnParar.Enabled = false;
            lblErrar.Text = errar;
            lblAcertar.Text = acertar;

            perguntas = new String[6];
            respostas = new String[6];
            alternativas1 = new String[6];
            alternativas2 = new String[6];
            alternativas3 = new String[6];
            alternativas4 = new String[6];
            ajudas1 = new String[6];
            ajudas2 = new String[6];

            perguntas[0] = "Qual é o antônimo de “malograr”?";
            respostas[0] = "Conseguir";
            alternativas1[0] = "Perder";
            alternativas2[0] = "Fracassar";
            alternativas3[0] = "Conseguir";
            alternativas4[0] = "Desprezar";

            perguntas[1] = "Qual nome se dá à purificação por meio da água?";
            respostas[1] = "Ablução";
            alternativas1[1] = "Abolição";
            alternativas2[1] = "Abnegação";
            alternativas3[1] = "Ablução";
            alternativas4[1] = "Abrupção";

            perguntas[2] = "Com base em 2015, qual país é o maior produtor de\n" +
                "cacau do mundo?";
            respostas[2] = "Costa do Marfim";
            alternativas1[2] = "Costa do Marfim";
            alternativas2[2] = "Argentina";
            alternativas3[2] = "Brasil";
            alternativas4[2] = "Nigéria";

            perguntas[3] = "Qual é a cor do golfinho que tem na bandeira da" +
                "\nAnguilla?";
            respostas[3] = "Laranja";
            alternativas1[3] = "Laranja";
            alternativas2[3] = "Verde";
            alternativas3[3] = "Marrom";
            alternativas4[3] = "Preto";

            perguntas[4] = "Qual foi o último Presidente do período da ditadura\n" +
                "militar no Brasil?";
            respostas[4] = "João Figueiredo";
            alternativas1[4] = "Costa e Silva";
            alternativas2[4] = "João Figueiredo";
            alternativas3[4] = "Ernesto Geisel";
            alternativas4[4] = "Emílio Médici";

            perguntas[5] = "Na história do progama “Show do Milhão” apenas uma\n" +
                "pessoa levou o prêmio máximo. A pergunta foi: Em que dia\n" +
                "nasceu e em que dia foi registrado o Ex-Presidente Lula?";
            respostas[5] = "6 e 27 de outubro";
            alternativas1[5] = "6 e 27 de outubro";
            alternativas2[5] = "7 e 26 de outubro";
            alternativas3[5] = "8 e 29 de outubro";
            alternativas4[5] = "9 e 28 de outubro";
        }
        #endregion

        #region Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            AgrupaBotoes();
            btnAjuda.Enabled = false;
            buttons[ajuda1].Enabled = false;
            buttons[ajuda2].Enabled = false;
        }
        #endregion

        #region Parar
        private void btnParar_Click(object sender, EventArgs e)
        {
            msg = "SE VOCÊ PARAR AGORA FICARÁ COM " + parar + " PONTOS";
            titulo = "Tem certeza?";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
        #endregion

        #region Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            msg = "Deseja sair do jogo?";
            titulo = "Saindo...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Cronômetro
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            lblTimer.Text = segundo.ToString();

            if (segundo == 0)
            {
                timer1.Enabled = false;

                msg = "QUE PENA... VOCÊ FICOU COM " + errar + " PONTOS";
                titulo = "TEMPO ESGOTADO!";
                botoes = MessageBoxButtons.OK;
                icone = MessageBoxIcon.Error;
                definido = MessageBoxDefaultButton.Button1;
                if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        #endregion
    }
}
