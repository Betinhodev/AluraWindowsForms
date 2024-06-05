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
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) 
            {
                //MessageBox.Show($"Right button pressed in the position {x.ToString()}, {y.ToString()}");

                var contextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Item do menu 1", "Frm_ValidaSenha1");
                var vToolTip002 = DesenhaItemMenu("Item do menu 1", "Frm_ValidaCPF1");
                contextMenu.Items.Add(vToolTip001);
                contextMenu.Items.Add(vToolTip002);
                contextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new EventHandler(vToolTip001_Click);
                vToolTip001.Click += new EventHandler(vToolTip002_Click);
            }
        }

        private void vToolTip001_Click(object sender, EventArgs e)
        {

        }
        
        private void vToolTip002_Click(object sender, EventArgs e)
        {

        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            Image myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = myImage;

            return vToolTip;
        }
    }
}
