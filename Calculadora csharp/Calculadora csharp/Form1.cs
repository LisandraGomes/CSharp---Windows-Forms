using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb.Text = "";
            num = 0;
            ndois = 0;
            temp = 0;
            lbresult.Text = "";
        }

        #region Variaveis
        //Variaveis
        Boolean existeponto = false, existeantes = false, positivado = true;
        Decimal num, ndois, temp, resultado;
        string operacao;
        #endregion

        #region Botão virgula
        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (existeponto == false)
            {
                tb.Text += ".";
                existeponto = true;
            }
            else
            { }

        }
        #endregion

        #region Botões numéricos
        private void btnzero_Click(object sender, EventArgs e)
        {
            tb.Text += "0";
        }
        private void btnum_Click(object sender, EventArgs e)
        {
            tb.Text += "1";
        }
        private void btndois_Click(object sender, EventArgs e)
        {
            tb.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            tb.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            tb.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            tb.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            tb.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            tb.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            tb.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            tb.Text += "9";
        }

        #endregion

        #region Botões C e CE
        private void btnce_Click(object sender, EventArgs e)
        {
            tb.Text = "";
            num = 0;
            ndois = 0;
            temp = 0;
            lbresult.Text = "";
            operacao = "";
            existeponto = false;
            existeantes = false;
        }


        private void btnc_Click(object sender, EventArgs e)
        {
            tb.Text = "";
            ndois = 0;
            operacao = "";
            existeponto = false;
            existeantes = false;
        }
        #endregion

        #region Botões Operações
        //Mais
        private void btnmais_Click(object sender, EventArgs e)
        {
            operacao = "+";
            lbresult.Text = Convert.ToString(num) + operacao;
            if (existeantes == false && tb.Text != "")
            {
                num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                tb.Text = "";
                existeantes = true;
                lbresult.Text = Convert.ToString(num) + operacao;
            }
            else
            {
                if (tb.Text != "" && existeantes == true)
                {
                    ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    resultado = num + ndois;
                    num = resultado;
                    tb.Text = "";
                    lbresult.Text = Convert.ToString(num) + operacao;
                }
                else { }
            }
        }
        //Menos
        private void btnmenos_Click(object sender, EventArgs e)
        {
            operacao = "-";
            lbresult.Text = Convert.ToString(num) + operacao;
            if (existeantes == false && tb.Text != "")
            {
                num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                tb.Text = "";
                existeantes = true;
                lbresult.Text = Convert.ToString(num) + operacao;
            }
            else
            {
                if (tb.Text != "" && existeantes == true)
                {
                    ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    tb.Text = "";
                    resultado = (num - ndois);
                    num = resultado;
                    lbresult.Text = Convert.ToString(num) + operacao;
                }
                else { }
            }
        }
        private void lbcal_Click(object sender, EventArgs e)
        {

        }

        private void lbresult_Click(object sender, EventArgs e)
        {

        }
        //Multiplica
        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            operacao = "*";
            lbresult.Text = Convert.ToString(num) + operacao;
            if (existeantes == false && tb.Text != "")
            {
                num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                tb.Text = "";
                existeantes = true;
                lbresult.Text = Convert.ToString(num) + operacao;
            }
            else
            {
                if (tb.Text != "" && existeantes == true)
                {
                    ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    resultado = num * ndois;
                    num = resultado;
                    tb.Text = "";
                    lbresult.Text = Convert.ToString(num) + operacao;
                }
                else { }
            }
        }
        //Dividir
        private void btndividir_Click(object sender, EventArgs e)
        {
            operacao = "/";
            lbresult.Text = Convert.ToString(num) + operacao;
            if (existeantes == false && tb.Text != "")
            {
                num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                tb.Text = "";
                existeantes = true;
                lbresult.Text = Convert.ToString(num) + operacao;
            }
            else
            {
                if (tb.Text != "" && existeantes == true)
                {
                    ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    resultado = num / ndois;
                    num = resultado;
                    tb.Text = "";
                    lbresult.Text = Convert.ToString(num) + operacao;
                }
                else { }
            }
        }
        private void btnporcent_Click(object sender, EventArgs e)
        {

        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            //Soma
            if(operacao == "+")
            {
                if (existeantes == false && tb.Text != "")
                {
                    num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    tb.Text = "";
                    existeantes = true;
                }
                else
                {
                    if (tb.Text != "" && existeantes == true)
                    {
                        ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                        resultado = num + ndois;
                        num = resultado;
                        tb.Text = "";
                        lbresult.Text = Convert.ToString(num);
                    }
                    else { }
                }
            }
            //Diminui
            if(operacao == "-")
            {
                if (existeantes == false && tb.Text != "")
                {
                    num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    tb.Text = "";
                    existeantes = true;
                }
                else
                {
                    if (tb.Text != "" && existeantes == true)
                    {
                        ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                        tb.Text = "";
                        resultado = (num - ndois);
                        num = resultado;
                        lbresult.Text = Convert.ToString(num);
                    }
                    else { }
                }
            }
            //Multiplica
            if (operacao == "*")
            {
                if (existeantes == false && tb.Text != "")
                {
                    num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    tb.Text = "";
                    existeantes = true;
                }
                else
                {
                    if (tb.Text != "" && existeantes == true)
                    {
                        ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                        resultado = num * ndois;
                        num = resultado;
                        tb.Text = "";
                        lbresult.Text = Convert.ToString(num);
                    }
                }
            }
            //Dividir
            if (operacao == "/")
            {
                if (existeantes == false && tb.Text != "")
                {
                    num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    tb.Text = "";
                    existeantes = true;
                }
                else
                {
                    if (tb.Text != "")
                    {
                        ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                        resultado = num / ndois;
                        num = resultado;
                        tb.Text = "";
                        lbresult.Text = Convert.ToString(num);
                    }
                }
            }
            }
        #endregion

        #region Botões de operação adicionais
        private void btnmaismenos_Click(object sender, EventArgs e)
        {
            if (positivado == true)
            {
                tb.Text = ("-" + tb.Text);
                positivado = false;
            }
            else
            {
                tb.Text = ("+" + tb.Text);
                positivado = true;
            }
        }
        private void btnquadrado_Click(object sender, EventArgs e)
        {
            if (existeantes == false && tb.Text != "")
            {
                num = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                resultado = num * num;
                num = resultado;
                tb.Text = "";
                existeantes = true;
                lbresult.Text = Convert.ToString(num);
            }
            else
            {
                if (tb.Text != "" && existeantes == true)
                {
                    ndois = Decimal.Parse(tb.Text, CultureInfo.InvariantCulture);
                    resultado = ndois * ndois;
                    num = resultado;
                    tb.Text = "";
                    lbresult.Text = Convert.ToString(num);
                }
                else { }
            }
        }

        #endregion
    }
}

