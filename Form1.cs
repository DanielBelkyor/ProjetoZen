using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBxName.Text, txtBxSenha.Text);
            MessageBox.Show(txtBxUserName.Text, cmBxStats.Text);
            MessageBox.Show(nmcNivel.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Hide();
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog savedlg = new SaveFileDialog();
            string filename = "";

            savedlg.Filter = "Rich text File (*.rtf)|*.rtf|Plain text File (*.txt)|*.txt";
            savedlg.DefaultExt = "*.rtf";
            savedlg.FilterIndex = 1;
            savedlg.Title = "Save the contents";

            DialogResult retval = savedlg.ShowDialog();
            if (retval == DialogResult.OK)
                filename = savedlg.FileName;
            else
                return;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(txtBxName.Text, txtBxUserName.Text);
            MessageBox.Show(txtBxSenha.Text, cmBxStats.Text);
            MessageBox.Show(nmcNivel.Text);
        }

        private void cmBxStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBxStats.Text == "A")
            {
                lblA.Visible = true;
                lblB.Visible = false;
                lblC.Visible = false;
            }
            else if(cmBxStats.Text == "B")
            {
                lblB.Visible = true;
                lblA.Visible = false;
                lblC.Visible = false;
            }
            else if (cmBxStats.Text == "C")
            {
                lblB.Visible = false;
                lblA.Visible = false;
                lblC.Visible = true;
            }
        }
    }
}
