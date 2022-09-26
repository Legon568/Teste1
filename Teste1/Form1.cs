using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form
    {
        Totalizador totaliza = new Totalizador();

        Veiculo[] veiculos = new Veiculo[10];

        int contador = 0;

        double ValorTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            if (rCarro.Checked)
            {

                if (txtValor.Text == "")
                {
                    MessageBox.Show("Necessário informar o valor do veículo!");
                }


                Carro v1 = new Carro()
                {
                    Modelo = txtModelo.Text,
                    Placa = txtPlaca.Text,
                    Km = Convert.ToDouble(txtKm.Text),
                    Valor = Convert.ToDouble(txtValor.Text)                
                };

                if (CbReboque.Checked)
                {
                    ValorTotal = v1.CalculaReboque() + v1.CalculaValor();
                }

                Adiciona(v1);

                MessageBox.Show($"Valor total é: R$ {v1.CalculaValor()}");
            }
            else if (rMoto.Checked)
            {

                if (txtValor.Text == "")
                {
                    MessageBox.Show("Necessário informar o valor do veículo!");
                }


                Moto v2 = new Moto()
                {
                    Modelo = txtModelo.Text,
                    Placa = txtPlaca.Text,
                    Km = Convert.ToDouble(txtKm.Text),
                    Valor = Convert.ToDouble(txtValor.Text)
                    
                };

                if (CbKit.Checked)
                {
                    v2.CalculaKit();
                }

                Adiciona(v2);

                MessageBox.Show($"Valor total é: R$ {v2.CalculaValor()}");

            }

            LimparDados();
        }
        public void Adiciona(Veiculo veiculo)
        {
            totaliza.Soma(veiculo);

            veiculos[contador] = veiculo;
            contador++;
        }
        private void LimparDados()
        {
            rCarro.Checked = false;
            rMoto.Checked = false;
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtKm.Text = "";
            txtValor.Text = "";
        
        }

        private void btnMostraTotal_Click(object sender, EventArgs e)
        {

            string lista = "";
            for (int i = 0; i < contador; i++)
            {
                lista += "Veiculo: " + i + " - Modelo: " + veiculos[i].Modelo + " \n";
            }

            MessageBox.Show("Lista de veiculos:\n" + lista
                + "O valor total dos veiculos : R$" + totaliza.TotalValor);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rMoto_CheckedChanged(object sender, EventArgs e)
        {
            CbReboque.Visible = false;
            CbKit.Visible = true;
        }

        private void rCarro_CheckedChanged(object sender, EventArgs e)
        {
            CbKit.Visible = false;
            CbReboque.Visible = true;
        }
    }
}
