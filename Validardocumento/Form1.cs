using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Validardocumento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Patente.Text!=""&& Lb_texto.Text == "" && Lb_texto.Text == "")
            {
                string patron = @"^[A-Z]{3}\d{3}$";
                string patron2 = @"^[A-Z]{2}\d{3}[A-Z]{2}$";
                string input = Txt_Patente.Text;
                
             

                if (Regex.IsMatch(input.ToUpper(), patron))
                {
                    MessageBox.Show("Patente valida");
                    Lb_texto.Text = input.ToUpper();

                }
                else if (Regex.IsMatch(input.ToUpper(), patron2))
                {
                    MessageBox.Show("Patente valida");
                    Lb_texto.Text = input.ToUpper();
                }
                else
                {
                    MessageBox.Show("Patente invalida");
                }
            }

            if (Txt_CUIL.Text!=""&&Lb_Dni.Text==""&&Lb_texto.Text=="")
            {
                string cuil = Txt_CUIL.Text.Trim();


                if (cuil.Length == 11 && cuil.All(char.IsDigit))
                {
                    string dni = cuil.Substring(2, 8);
                    string cuilFormateado = $"{cuil.Substring(0, 2)}-{cuil.Substring(2, 8)}-{cuil.Substring(10)}";
                    string mensaje = "El CUIL ingresado es: " + cuilFormateado;
                    string mensaje2 = "El DNI es: " + dni;

                    Lb_texto.Text = cuilFormateado;
                    Lb_Dni.Text = dni;

                }
                else
                {
                    MessageBox.Show("Ingrese un CUIL válido de 11 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void Bt_limpiar_Click(object sender, EventArgs e)
        {
            Lb_texto.Text = "";
            Lb_Dni.Text = "";
            Txt_CUIL.Text = "";
            Txt_Patente.Text = "";
        }
    }
}
