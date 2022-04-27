using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalc
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }//Fim do construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void soma_Click(object sender, EventArgs e)
        {
            try
            {
            double n1 = Convert.ToDouble(boxn1.Text);//Coletando o número 1.
            double n2 = Convert.ToDouble(boxn2.Text);//Coletando o número 2.
            double resultado = model.Somar(n1, n2);//Gerando resultado.
            result.Text = "" + resultado;//Escrever o resultado na tela.
            }
            catch (Exception erro)
            {

                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
           

        }//Fim do botão somar.

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(boxn1.Text);//Coletando o número 1.
                double n2 = Convert.ToDouble(boxn2.Text);//Coletando o número 2.
                double resultado = model.Subtracao(n1, n2);//Gerando resultado.
                result.Text = "" + resultado;//Escrever o resultado na tela.
            }
            catch (Exception erro)
            {

                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
            
        }//Fim do botão subtrair.

        private void mult_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(boxn1.Text);//Coletando o número 1.
                double n2 = Convert.ToDouble(boxn2.Text);//Coletando o número 2.
                double resultado = model.Multiplicacao(n1, n2);//Gerando resultado.
                result.Text = "" + resultado;//Escrever o resultado na tela.
            }
            catch (Exception erro)
            {

                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
            
        }//Fim do botão do multplicar.

        private void divi_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(boxn1.Text);//Coletando o número 1.
                double n2 = Convert.ToDouble(boxn2.Text);//Coletando o número 2.
                double resultado = model.Divisao(n1, n2);//Gerando resultado.
            if(resultado == -1)
            {
                result.Text = "Impossível dividir por zero!";
            }
            else
            {
                result.Text = "" + resultado;
            }
            result.Text = "" + resultado;//Escrever o resultado na tela.
            }
            catch (Exception)
            {
                throw;
            }
           
        }//Fim do botão dividir.
        private void potencia_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(boxn1.Text);//Coletando o número 1.
                double n2 = Convert.ToDouble(boxn2.Text);//Coletando o número 2.
                double resultado = model.Potencia(n1, n2);//Gerando resultado.
                result.Text = "" + resultado;//Escrever o resultado na tela.
            }
            catch (Exception erro) { MessageBox.Show("Os números não foram digitados!\n\n" + erro); }
        }//Fim do botão potencia.
        private void raiz_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(boxn1.Text);//Coletando o número 1.
                double n2 = Convert.ToDouble(boxn2.Text);//Coletando o número 2.
                double resultado = model.Raiz(n1);//Gerando resultado.
            if (model.Raiz(n1) == -1)
            {
                result.Text = "Não foi possível calcular!";
            }
            else
            {
                result.Text = "" + resultado;
            }
            result.Text = "" + resultado;//Escrever o resultado na tela.
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
            
        }//Fim do botão radiaciação.










        private void numero1_Click(object sender, EventArgs e)
        {
        }//Fim escrita N1.
        private void numero2_Click(object sender, EventArgs e)
        {
        }//Fim escrita N2.
        private void boxn1_TextChanged(object sender, EventArgs e)
        {
        }//Fim Caixa 1.
        private void boxn2_TextChanged(object sender, EventArgs e)
        {
        }//Fim Caixa 2.
        private void result_Click(object sender, EventArgs e)
        {
        }//Fim Resultado.
    }//Fim da Classe;
}//Fim do Projeto;
