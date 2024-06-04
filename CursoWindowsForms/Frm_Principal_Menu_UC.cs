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
    public partial class Frm_Principal_Menu_UC : Form
    {

        int controleHelloWorld = 0;
        int controleDemonstracaoKey = 0;
        int controleMascara = 0;
        int controleValidaCPF = 0;
        int controleValidaCPF2 = 0;
        int controleValidaSenha = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }
        private void demonstracaoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleDemonstracaoKey += 1;

            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Demonstração Key " + controleDemonstracaoKey;
            TB.Text = "Demonstração Key " + controleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleHelloWorld += 1;

            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Hello World " + controleHelloWorld;
            TB.Text = "Hello Word " + controleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleMascara += 1;

            Frm_Mascara_UC U = new Frm_Mascara_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Mascara " + controleMascara;
            TB.Text = "Mascara " + controleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaCPF += 1;

            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valida CPF " + controleValidaCPF;
            TB.Text = "Valida CPF " + controleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaCPF2 += 1;

            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valida CPF 2 " + controleValidaCPF2;
            TB.Text = "Valida CPF 2 " + controleValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaSenha += 1;

            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valida Senha " + controleValidaSenha;
            TB.Text = "Valida Senha " + controleValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }
    }
}