using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoEstudio2
{
    public partial class Calculadora : Form
    {
        double num1 = 0, num2 = 0;
        char option;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += boton.Text;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResultado.Text);

            if (option == '+')
            {
                txtResultado.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (option == '-')
            {
                txtResultado.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (option == 'x')
            {
                txtResultado.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (option == '/')
            {
                txtResultado.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            option = '\0';
            txtResultado.Text = "0";
        }

        private void btnDeleteNumber_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if(!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResultado.Text);
            num1 *= -1;
            txtResultado.Text = num1.ToString();

        }

        private void clickOption(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txtResultado.Text);
            option = Convert.ToChar(boton.Text);
            txtResultado.Text = "0";
        }

    }
}
