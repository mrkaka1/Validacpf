using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tx_resu.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string sexo = cmb_sexo.Text;
            string idade =tx_idade.Text;
            double peso = Convert.ToDouble(tx_peso.Text);
            double altura = Convert.ToDouble(tx_altura.Text);
            string cpf = mx_cpf.Text;
            Calcular imc = new Calcular(nome, cpf, idade, peso, altura, sexo);
            /*imc.altura = Convert.ToDouble(tx_altura.Text);
            imc.peso = Convert.ToDouble(tx_peso.Text); */
            bool valido = Validacoes.ValidaCPF(mx_cpf.Text);

            if (valido == true)
            {
                MessageBox.Show($"O CPF {valido.ToString()} de {tx_nome.Text} é válido!");
            }
            else
            {
                MessageBox.Show("CPF inválido");
            }

            (double a ,string b,string c) = imc.Imc();
            tx_resu.Text = a.ToString("0.0") + b.ToString() + c.ToString() + " " + valido; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_altura.Clear();
            tx_peso.Clear();
            tx_idade.Clear();
            tx_nome.Clear();
            cmb_sexo.Text = "";
            mx_cpf.Clear();
            tx_resu.Text = "";
        }
    }
}
