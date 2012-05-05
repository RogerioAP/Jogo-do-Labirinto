using System;/*Rogério Almeida Pereira*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class Labirinto : Form
    {
        public Labirinto()
        {
            InitializeComponent();
        }
        int x = 0;

        private void lblChegada_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            if(lblContagem.Text == "0") { MessageBox.Show("Você trapasseou!", "Que vergonha hei!"); x = 0; }
            else if (x > 0) { MessageBox.Show("Você ganhou! Com o tempo de " + lblContagem.Text + ".", "Parabéns!"); x = 0; }
            else { MessageBox.Show("Você trapasseou!", "Que vergonha hei!"); x = 0; }
            lblContagem.Text = "0";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Errou. Recomece na \"Saída\".", "Que pena...");
            x = 0;
            lblContagem.Text = "0";
        }

        int soma=0;
        private int Soma()
        {
            soma = soma + 1;
            return soma;/*Rogério Almeida Pereira*/
        }

        public void lblPonto1_MouseEnter(object sender, EventArgs e)
        {
            x = Soma();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int r = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            r = int.Parse(lblContagem.Text);
            r++;
            lblContagem.Text = r.ToString();
        }

        private void lblSaida_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
