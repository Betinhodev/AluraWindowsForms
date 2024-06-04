﻿using CursoWindowsFormsBiblioteca;
using System;
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
    public partial class Frm_ValidaCPF2_UC : UserControl
    {
        public Frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo = Msk_CPF.Text
                .Replace(".", "")
                .Replace("-", "")
                .Trim();


            if (vConteudo == "")
            {
                MessageBox.Show("O Campo CPF não pode ser vazio.", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vConteudo.Length != 11)
            {
                MessageBox.Show("É necessário incluir todos os dígitos do CPF.", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_Questao questionDialog = new Frm_Questao("Frm_Question", "Você deseja validar o CPF?");
                questionDialog.ShowDialog();
                //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


                    if (questionDialog.DialogResult == DialogResult.Yes)
                {
                    bool validaCpf = false;
                    validaCpf = Cls_Uteis.Valida(Msk_CPF.Text);
                    if (validaCpf == true)
                    {
                        MessageBox.Show("CPF Válido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF Inválido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
