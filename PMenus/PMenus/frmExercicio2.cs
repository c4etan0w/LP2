﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenus
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void frmExercicio2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTestarIguais_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPalavra1.Text,
                txtPalavra2.Text, true) == 0)
                MessageBox.Show("São Iguais");
            else
                MessageBox.Show("São Diferentes");

        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int meio = lblPalavra2.Text.Length / 2;

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + txtPalavra1.Text + 
                txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length - meio);
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");
        }
    }
}
