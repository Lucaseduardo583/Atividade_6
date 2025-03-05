using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class Form1: Form
        
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
        1 – Adição 2 – Subtração 3 – Multiplicação 4 – Divisão */
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado = 0;

            if (cbo_operacao.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma operação antes de calcular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string operacao = cbo_operacao.SelectedItem?.ToString();

            if (double.TryParse(txt_n1.Text, out numero1) && double.TryParse(txt_n2.Text, out numero2))
            {
                switch (operacao)
                {
                    case "1 - Adição":
                        resultado = numero1 + numero2;
                        break;
                    case "2 - Subtração":
                        resultado = numero1 - numero2;
                        break;
                    case "3 - Multiplicação":
                        resultado = numero1 * numero2;
                        break;
                    case "4 - Divisão":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            MessageBox.Show("Erro: Divisão por zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Selecione uma operação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                lbl_resultado.Text = $"Resultado: {resultado:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
