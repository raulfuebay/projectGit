using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDNI
{
    public partial class Form1 : Form
    {
        //RAÚL FUERTES BAYÓN
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBoxDNI.Text);
            char letter = functionDNI(dni);
            textBoxLetter.Text = letter.ToString();
        }

        private char functionDNI(int dni)
        {
            //char letter = 'A';
            //string letter = "TRWAGMYFPDXBNJZSQVHLCKE"[dni % 23];


            return "TRWAGMYFPDXBNJZSQVHLCKE"[dni % 23];
        }
    }
}
