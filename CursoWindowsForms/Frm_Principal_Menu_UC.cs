using CursoWindowsFormsBiblioteca;
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
    public partial class Frm_Principal_Menu_UC : Form
    {

        int controleHelloWorld = 0;
        int controleDemonstracaoKey = 0;
        int controleMascara = 0;
        int controleValidaCPF = 0;
        int controleValidaCPF2 = 0;
        int controleValidaSenha = 0;
        int controleArquivoImagem = 0;
        int controleCadastroClientes = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            byteBankToolStripMenuItem.Enabled = false;
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
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialogBox = new OpenFileDialog();
            dialogBox.InitialDirectory = "C:\\Users\\gsnogueira\\source\\repos\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            dialogBox.Filter = "PNG|*.PNG";
            dialogBox.Title = "Escolha a Imagem";

            if(dialogBox.ShowDialog() == DialogResult.OK)
            {

                string nomeArquivoImagem = dialogBox.FileName;
                

                controleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                TabPage TB = new TabPage();
                U.Dock = DockStyle.Fill;
                TB.Name = "Arquivo Imagem " + controleArquivoImagem;
                TB.Text = "Arquivo Imagem " + controleArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }

            
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.ShowDialog();

            if(login.DialogResult == DialogResult.OK)
            {
                string senha = login.senha;
                string usuario = login.login;

                if(Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    byteBankToolStripMenuItem.Enabled = true;

                    MessageBox.Show($"Bem-Vindo {usuario}!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha incorreta.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conectarToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao questionDialog = new Frm_Questao("Frm_Question", "Você deseja se desconectar?");
            questionDialog.ShowDialog();

            if(questionDialog.DialogResult == DialogResult.Yes)
            {
                for(int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i--)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                byteBankToolStripMenuItem.Enabled = false;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show($"Right button pressed in the position {x.ToString()}, {y.ToString()}");

                var contextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar Todas a Esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar Todas a Direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar Todas Menos Esta", "DeleteAll");
                contextMenu.Items.Add(vToolTip001);
                contextMenu.Items.Add(vToolTip002);
                contextMenu.Items.Add(vToolTip003);
                contextMenu.Items.Add(vToolTip004);
                contextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new EventHandler(vToolTip001_Click);
                vToolTip002.Click += new EventHandler(vToolTip002_Click);
                vToolTip003.Click += new EventHandler(vToolTip003_Click);
                vToolTip004.Click += new EventHandler(vToolTip004_Click);
            }
        }
        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            Image myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = myImage;

            return vToolTip;
        }

        void ApagaEsquerda(int itemSelecionado)
        {
            for (int i = itemSelecionado - 1; i >= 0; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        void ApagaDireita(int itemSelecionado)
        {
            int itemCount = Tbc_Aplicacoes.TabPages.Count;

            for (int i = itemCount - 1; i > itemSelecionado; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(controleCadastroClientes == 0)
            {
                controleCadastroClientes += 1;
                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                TabPage TB = new TabPage();
                U.Dock = DockStyle.Fill;
                TB.Name = "Cadastro de Clientes";
                TB.Text = "Cadastro de Clientes";
                TB.ImageIndex = 11;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Não é possível abrir outro Cadastro de Clientes pois já possui uma aba aberta.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void ApagaAba(TabPage TB)
        {
            if(TB.Name == "Cadastro de Clientes")
            {
                controleCadastroClientes = 0;
            }

            Tbc_Aplicacoes.TabPages.Remove(TB);
        }
    }

}

