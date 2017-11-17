using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula07032017JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string VezDe = "";

        public void primeiro()
        {
            if (radioButton1.Checked == true && radioButton1.Enabled == true)
            {
                VezDe = "X";
                lbl.Text = "Vez de: " + VezDe;
            }
            if (radioButton2.Checked == true && radioButton2.Enabled == true)
            {
                VezDe = "O";
                lbl.Text = "Vez de: " + VezDe;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            primeiro();
        }

        

        public Int32 PlacarX = 0;

        public Int32 PlacarO = 0;

        public string TrocarVez()
        {
            if (VezDe == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public void Recomecar()
        {
            btn1.Text = "";
            btn1.Enabled = true;
            btn2.Text = "";
            btn2.Enabled = true;
            btn3.Text = "";
            btn3.Enabled = true;
            btn4.Text = "";
            btn4.Enabled = true;
            btn5.Text = "";
            btn5.Enabled = true;
            btn6.Text = "";
            btn6.Enabled = true;
            btn7.Text = "";
            btn7.Enabled = true;
            btn8.Text = "";
            btn8.Enabled = true;
            btn9.Text = "";
            btn9.Enabled = true;
            VezDe = "";
            lbl.Text = "Vez de: " + VezDe;
            radioButton1.Enabled = true;
            radioButton1.Visible = true;
            radioButton2.Enabled = true;
            radioButton2.Visible = true;
            lbl3.Visible = true;
        }

        public void Vencer()
        {
            if (VezDe == "X")
                PlacarX = PlacarX + 1;
            if (VezDe == "O")
                PlacarO = PlacarO + 1;
            lbl2.Text = "Placar: \n\rX: " + PlacarX + "\n\rO: " + PlacarO;


            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        public bool Checar(string jogador)
        {
            if (btn1.Text == jogador && btn2.Text == jogador && btn3.Text == jogador)
            {
                Vencer();
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na primeira linha!", "Parabéns!");
                Recomecar();
                return true;
            }
            if (btn4.Text == jogador && btn5.Text == jogador && btn6.Text == jogador)
            {
                Vencer();
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na segunda linha!", "Parabéns!");
                Recomecar();
                return true;
            }
            if (btn7.Text == jogador && btn8.Text == jogador && btn9.Text == jogador)
            {
                Vencer(); 
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na terceia linha!", "Parabéns!");
                Recomecar();
                return true;
            }
            if (btn1.Text == jogador && btn4.Text == jogador && btn7.Text == jogador)
            {
                Vencer();
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na primeira coluna!", "Parabéns!");
                Recomecar();
                return true;
            }
            if (btn2.Text == jogador && btn5.Text == jogador && btn8.Text == jogador)
            {
                Vencer();
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na segunda liha!", "Parabéns!");
                Recomecar();
                return true;
            }
            if (btn3.Text == jogador && btn6.Text == jogador && btn9.Text == jogador)
            {
                Vencer();
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na terceira coluna!", "Parabéns!");
                Recomecar();
                return true;
            }
            if (btn1.Text == jogador && btn5.Text == jogador && btn9.Text == jogador)
            {
                Vencer();
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na diagonal direita!", "Parabéns!");
                Recomecar();
                return true;
            }
            if (btn3.Text == jogador && btn5.Text == jogador && btn7.Text == jogador)
            {
                Vencer();
                MessageBox.Show("Jogador " + VezDe + " venceu a partida na diagonal esquerda!", "Parabéns!");
                Recomecar();
                return true;
            }

            /*Velha*/
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                string velha;
                velha = MessageBox.Show("Deu velha! Deseja iniciar uma nova partida?", "Velha!", MessageBoxButtons.YesNo).ToString();
                if (velha == "Yes")
                {
                Recomecar();
                return true;
                }
            }

            VezDe = TrocarVez();
            lbl.Text = "Vez de: " + VezDe;
            return false;
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            Recomecar();
        }

        public void disable()
        {
            radioButton1.Enabled = false;
            radioButton1.Visible = false;
            radioButton2.Enabled = false;
            radioButton2.Visible = false;
            lbl3.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn1.Text = VezDe;
            btn1.Enabled = false;
            Checar(VezDe);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn2.Text = VezDe;
            btn2.Enabled = false;
            Checar(VezDe);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn3.Text = VezDe;
            btn3.Enabled = false;
            Checar(VezDe);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn4.Text = VezDe;
            btn4.Enabled = false;
            Checar(VezDe);
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            primeiro();
            disable();
            btn5.Text = VezDe;
            btn5.Enabled = false;
            Checar(VezDe);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn6.Text = VezDe;
            btn6.Enabled = false;
            Checar(VezDe);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn7.Text = VezDe;
            btn7.Enabled = false;
            Checar(VezDe);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn8.Text = VezDe;
            btn8.Enabled = false;
            Checar(VezDe);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            primeiro();
            disable();
            btn9.Text = VezDe;
            btn9.Enabled = false;
            Checar(VezDe);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcao;
            opcao = MessageBox.Show("Deseja realmente SAIR?", "Fechar", MessageBoxButtons.YesNo).ToString();
            if (opcao == "Yes")
            {
                opcao = MessageBox.Show("TEM CERTEZA?", "Fechar", MessageBoxButtons.YesNo).ToString();
                if (opcao == "Yes")
                    this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jogo da Velha criado por Bruno Rodrigues Ricardo, 2º info C, Nº 4\r\nAula de Lógica de Programação, Professor Edemir Gomes", "Autoria");
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btnApagarPlacar_Click(object sender, EventArgs e)
        {
            string placar;
            placar = MessageBox.Show("Deseja mesmo zerar o placar?", "Apagar placar?", MessageBoxButtons.YesNo).ToString();
            if (placar == "Yes")
            {
                PlacarX = 0;
                PlacarO = 0;
                lbl2.Text = "Placar: \n\rX: " + PlacarX + "\n\rO: " + PlacarO;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            VezDe = "X";
            lbl.Text = "Vez de: " + VezDe;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            VezDe = "O";
            lbl.Text = "Vez de: " + VezDe;
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }




        
    }
}
