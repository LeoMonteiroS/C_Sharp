using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // BOTAO DE LIMPAR
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }

                this.Controls["label7"].Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) //BOTÃO DE CALCULAR
        {
            float soma;
            soma = 0;
            int quantidade = 0;



            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    soma += Convert.ToSingle(((TextBox)controle).Text);
                    quantidade++;
                }
                if (quantidade > 0)
                {
                    float media = soma / quantidade;
                    this.Controls["label7"].Text = media.ToString();
                }
                else
                {
                    this.Controls["label7"].Text = "0"; // ou qualquer valor padrão se nenhum TextBox for preenchido
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
