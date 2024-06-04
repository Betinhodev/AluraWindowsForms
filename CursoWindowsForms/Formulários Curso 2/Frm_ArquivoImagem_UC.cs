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
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_Imagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Lbl_Imagem.ForeColor = colorDialog.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                Lbl_Imagem.Font = fontDialog.Font;
            }
        }
    }
}
