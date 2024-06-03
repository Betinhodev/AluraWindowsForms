﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
        }
        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;
            validaCpf = Cls_Uteis.Valida(Msk_CPF.Text);
            if(validaCpf == true)
            {
                Lbl_Resultado.Text = "Cpf Válido";
                Lbl_Resultado.ForeColor = Color.ForestGreen;
            }
            else
            {
                Lbl_Resultado.Text = "Cpf Inválido";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }

    }
}
